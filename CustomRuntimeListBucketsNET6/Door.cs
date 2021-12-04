using System.Xml;
using System.Xml.Linq;

namespace CustomRuntimeListBucketsNET6
{
    internal class Door
    {
        private const int _wallGap = 100;
        private const int _gapBetweenDoors = 100;
        public string Name { private get; set; } = "";
        public string Description { private get; set; } = "";
        public int Width { private get; set; } = 0;
        public int Height { get; set; } = 0;
        public int Depth { get; set; } = 0;
        public int Hinge1Position { get; set; } = 0;
        public int Hinge2Position { get; set; } = 0;
        public int Hinge3Position { get; set; } = 0;
        public int Hinge4Position { get; set; } = 0;
        public int Hinge5Position { get; set; } = 0;
        public string HingeLocation { get; set; } = "L";
        private double? _positionOnWall; 

        public XElement CreateXElement()
        {
            if (_positionOnWall == null) throw new Exception("_positionOnWall must be set by calling SetPositonOnWall before calling CreateXElement()");

            const string stringFormatSpecifier = "F4";

            Assembly assembly = new Assembly();
            assembly.Name.Value = Name;
            assembly.Description.Value = Description; 
            assembly.AssemblyWidth.Value = Width.ToString(stringFormatSpecifier);
            assembly.AssemblyHeight.Value = Height.ToString(stringFormatSpecifier);
            assembly.AssemblyDepth.Value = Depth.ToString(stringFormatSpecifier);
            assembly.AssemblyPosition.Value = _positionOnWall.Value.ToString(stringFormatSpecifier);

            assembly.Hinge1.Value = Hinge1Position.ToString(stringFormatSpecifier);
            assembly.Hinge2.Value = Hinge2Position.ToString(stringFormatSpecifier);
            assembly.Hinge3.Value = Hinge3Position.ToString(stringFormatSpecifier);
            assembly.Hinge4.Value = Hinge4Position.ToString(stringFormatSpecifier);
            assembly.Hinge5.Value = Hinge5Position.ToString(stringFormatSpecifier);



            assembly.FirstSectionWidth.Value = Width.ToString(stringFormatSpecifier);
            assembly.FirstSectionHeight.Value = Height.ToString(stringFormatSpecifier);
            assembly.FirstSectionHingeLocation.Value = HingeLocation;


            assembly.SecondSectionWidth.Value = Width.ToString(stringFormatSpecifier);
            assembly.SecondSectionHeight.Value = Height.ToString(stringFormatSpecifier);

            return assembly.doorAssemblyElement;
        }

        public void SetPositionOnWall(XElement assemblies, XElement wall)
        {
            if (assemblies == null) throw new ArgumentNullException(nameof(assemblies));
            if (wall == null) throw new ArgumentNullException(nameof(wall));

            // if there are no other doors, we must position at the beginning of the wall
            if (assemblies.Elements("Assembly").Count() == 0)
            {
                _positionOnWall = _wallGap;
                return;
            }

            // if there is another door we need to change the new door position to ensure they don't overlap
                string lastDoorPositionValue = ((assemblies.Elements("Assembly").Last()
                .Element("Position") ?? throw new XmlException("Can't find assembly.position"))
                .Element("X") ?? throw new XmlException("Can't find assembly.position.X"))
                .Value;
                double lastDoorPosition = double.Parse(lastDoorPositionValue);

                string lastDoorWidthValue = ((((assemblies.Elements("Assembly").Last()
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Size") ?? throw new XmlException("Can't find assembly.properties.general.size"))
                .Element("Width") ?? throw new XmlException("Can't find job.properties.general.size.width"))
                .Value;

                double lastDoorWidth = double.Parse(lastDoorWidthValue);

                _positionOnWall = lastDoorPosition + lastDoorWidth + _gapBetweenDoors;
        }
    }
}
