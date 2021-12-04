using System.Xml;
using System.Xml.Linq;

namespace CustomRuntimeListBucketsNET6
{
    internal class Assembly
    {
        public XElement Name { get; private set; }
        public XElement Description { get; private set; }
        public XElement AssemblyHeight { get; private set; }
        public XElement AssemblyWidth { get; private set; }
        public XElement AssemblyDepth { get; private set; }
        public XElement AssemblyPosition { get; private set; }
        public XElement Hinge1 { get; private set; }
        public XElement Hinge2 { get; private set; }
        public XElement Hinge3 { get; private set; }
        public XElement Hinge4 { get; private set; }
        public XElement Hinge5 { get; private set; }
        public XElement FirstSectionWidth { get; private set; }
        public XElement FirstSectionHeight { get; private set; }
        public XElement FirstSectionHingeLocation { get; private set; }
        public XElement SecondSectionWidth { get; private set; }
        public XElement SecondSectionHeight { get; private set; }

    public XElement doorAssemblyElement { get; private set; } 
        public Assembly()
        {

            const string asssemblyTemplate = @"<Assembly> 
              <Catalog> HighQ Cabinets</Catalog>
              <!--If catalog is not specified is uses value from Preferences|Fill Objects-->
              <Properties>
                <General>
                  <Name>Door or Draw Front</Name>
                  <Description>Door or Draw Front</Description>
                  <!--Class and Type are optional and must match the item or no item will be selected. It is recommended to omit them-->
                  <Class>Base</Class>
                  <Type>Standard</Type>
                  <Size>
                    <!-- Liviu: Door dimensions according to word document-->
                    <Width>860.000</Width>
                    <Height>2720.000</Height>
                    <Depth>560.000</Depth>
                  </Size>
                </General>
                <Case>
                  <Top>No Top</Top>
                  <!--No Top|Stretchers|Web Frame|Gussets|Full Top-->
                  <Bottom>No Bottom</Bottom>
                  <!--No Bottom|Standard-->
                </Case>
                <Reveals>
                  <Top>0.000</Top>
                  <Bottom>0.000</Bottom>
                  <Left>0.000</Left>
                  <Right>0.000</Right>
                  <Vertical>0.000</Vertical>
                  <Horizontal>0.000</Horizontal>
                  <EqualizeDoorWidthsAndDrawerHeights>0</EqualizeDoorWidthsAndDrawerHeights>
                </Reveals>
                <Toe>
                  <ToeHeight>0.000</ToeHeight>
                </Toe>
                <Attributes>
                  <Parameter>
                    <Name>Hinge1</Name>
                    <Description>Hinge 1</Description>
                    <Type>M</Type>
                    <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                    <Value>3.937008</Value>
                    <Style>Attribute</Style>
                    <!--Attribute|Note|Standard *standard is default if missing-->
                  </Parameter>
                  <Parameter>
                    <Name>Hinge2</Name>
                    <Description>Hinge 2</Description>
                    <Type>M</Type>
                    <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                    <Value>7.874016</Value>
                    <Style>Attribute</Style>
                    <!--Attribute|Note|Standard *standard is default if missing-->
                  </Parameter>
                  <Parameter>
                    <Name>Hinge3</Name>
                    <Description>Hinge 3</Description>
                    <Type>M</Type>
                    <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                    <Value>11.811024</Value>
                    <Style>Attribute</Style>
                    <!--Attribute|Note|Standard *standard is default if missing-->
                  </Parameter>
                  <Parameter>
                    <Name>Hinge4</Name>
                    <Description>Hinge 4</Description>
                    <Type>M</Type>
                    <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                    <Value>15.748031</Value>
                    <Style>Attribute</Style>
                    <!--Attribute|Note|Standard *standard is default if missing-->
                  </Parameter>
                  <Parameter>
                    <Name>Hinge5</Name>
                    <Description>Hinge 5</Description>
                    <Type>M</Type>
                    <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                    <Value>35.433071</Value>
                    <Style>Attribute</Style>
                    <!--Attribute|Note|Standard *standard is default if missing-->
                  </Parameter>
                </Attributes>
              </Properties>
              <Position>
                <X>990.000</X>
              </Position>
              <Sides>
                <!--Sides only need to be output if they have been modified by the user.-->
                <Side>
                  <Index>0</Index>
                  <Type>End</Type>
                  <End>No End</End>
                </Side>
                <Side>
                  <Index>2</Index>
                  <Type>End</Type>
                  <End>No End</End>
                </Side>
                <Side>
                  <Index>3</Index>
                  <Type>Back</Type>
                  <Back>No Back</Back>
                </Side>
              </Sides>
              <Sections>
                <!-- Liviu: is this the definition of the door or the one at line 1387 Assemblies-Assembly-Properties-General -->
                <Section Side=""1"" Type=""e"">
                  <Face>
                    <Type>Door</Type>
                    <!--door|pair|slide|drawer|falsefront|open|panel|blankpanel-->
                    <Dimensions>
                      <!--Dimensions are optional unless a specific size is required-->
                      <Width>860.000</Width>
                      <Height>2720.000</Height>
                    </Dimensions>
                    <Door>
                      <Hinge>L</Hinge>
                      <!--L|R|T|B|N|Left|Right|Top|Bottom|None-->
                    </Door>
                  </Face>
                </Section>
                <Section Side=""1"" Type=""i"">
                  <Open>
                    <Dimensions>
                      <Width>860.000</Width>
                      <Height>2720.000</Height>
                    </Dimensions>
                  </Open>
                </Section>
              </Sections>
              <Modifications>
                <DefaultAssembly>
                  <!--NOTE: DefatultAssembly is a reset. If you are NOT outputting section information, then you would want to skip this step to retain the original sections.-->
                  <!--NOTE: Since this file is demonstrating section output you must frist default the assembly or you will essentially begin sectioning an already sectioned cabinet.-->
                  <RemoveShapeTemplates>1</RemoveShapeTemplates>
                  <RemoveUserModifiedParameters>1</RemoveUserModifiedParameters>
                </DefaultAssembly>
                <HideParts>
                  <InteriorParts Side = ""1""> 1 </InteriorParts>
                </HideParts>
              </Modifications>
              <AdditionalParts>
                <Part>
                  <Name> TS </Name>
                  <Description> Reference Rail</Description>
                  <Size>
                    <Thickness>16.400</Thickness>
                  </Size>
                  <Material>HMR White 16mm</Material>
                  <Parameters>
                    <Parameter>
                      <Name>QTY</Name>
                      <Type>M</Type>
                      <!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
                      <Value>0</Value>
                    </Parameter>
                  </Parameters>
                </Part>
              </AdditionalParts>
              <PartOverrides>
                <PartOverride>
                  <Name>Cab.Face.DOR_OPEN.DOR.S_DSLAB</Name>
                  <Shape>
                    <Axis>XY</Axis>
                    <template firstid = ""1"" unit= ""mm"">
                      <geometry>
                        <entity id= ""1"" type= ""line2d"">
                          <end>
                            <x> 860.00001 </x>
                          </end>
                          <parameters>
                            <parameter name= ""_PROFTYPE"">
                              <value type= ""4""> 1 </value>
                            </parameter>
                            <parameter name= ""_SDEUSE"">
                              <value type= ""4""> 17 </value>
                            </parameter>
                          </parameters>
                        </entity>
                        <entity id= ""2"" type= ""line2d"">
                          <begin>
                            <x> 860.00001 </x>
                          </begin>
                          <end>
                            <x> 860.00001 </x>
                            <y> 2720 </y>
                          </end>
                          <parameters>
                            <parameter name= ""_PROFTYPE"">
                              <value type= ""4""> 1 </value>
                            </parameter>
                            <parameter name= ""_SDEUSE"">
                              <value type= ""4""> 5 </value>
                            </parameter>
                          </parameters>
                        </entity>
                        <entity id= ""3"" type= ""line2d"">
                          <begin>
                            <x> 860.00001 </x>
                            <y> 2720 </y>
                          </begin>
                          <end>
                            <y> 2720 </y>
                          </end>
                          <parameters>
                            <parameter name= ""_PROFTYPE"">
                              <value type= ""4""> 1 </value>
                            </parameter>
                            <parameter name= ""_SDEUSE"">
                              <value type= ""4""> 9 </value>
                            </parameter>
                          </parameters>
                        </entity>
                        <entity id= ""4"" type= ""line2d"">
                          <begin>
                            <y> 2720 </y>
                          </begin>
                          <parameters>
                            <parameter name= ""_PROFTYPE"">
                              <value type= ""4""> 1 </value>
                            </parameter>
                            <parameter name= ""_SDEUSE"">
                              <value type= ""4""> 3 </value>
                            </parameter>
                          </parameters>
                        </entity>
                      </geometry>
                    </template>
                  </Shape>
                </PartOverride>
              </PartOverrides>
            </Assembly>";

            doorAssemblyElement = XElement.Parse(asssemblyTemplate);


            Name = ((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Name") ?? throw new XmlException("Can't find assembly.properties.general.name");

            Description = ((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Description") ?? throw new XmlException("Can't find assembly.properties.general.description");

            AssemblyWidth = (((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Size") ?? throw new XmlException("Can't find assembly.properties.general.size"))
                .Element("Width") ?? throw new XmlException("Can't find job.properties.general.size.width");

            AssemblyHeight = (((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Size") ?? throw new XmlException("Can't find assembly.properties.general.size"))
                .Element("Height") ?? throw new XmlException("Can't find assembly.properties.general.size.height");

            AssemblyDepth = (((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("General") ?? throw new XmlException("Can't find assembly.properites.general"))
                .Element("Size") ?? throw new XmlException("Can't find assembly.properties.general.size"))
                .Element("Depth") ?? throw new XmlException("Can't find assembly.properties.general.size.depth");

            AssemblyPosition = ((doorAssemblyElement
                .Element("Position") ?? throw new XmlException("Can't find assembly.position"))
                .Element("X") ?? throw new XmlException("Can't find assembly.position.X"));

            Hinge1 = ((((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("Attributes") ?? throw new XmlException("Can't find assembly.properties.attributes"))
                .Descendants("Parameter") ?? throw new XmlException("Can't find aseembly.properties.attributes.parameter"))
                .First(x => (x.Element("Name") ?? throw new XmlException("Can't find assmembly.properties.attributes.paramenter.name")).Value == "Hinge1") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge1"))
                .Element("Value") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge1.value");

            Hinge2 = ((((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("Attributes") ?? throw new XmlException("Can't find assembly.properties.attributes"))
                .Descendants("Parameter") ?? throw new XmlException("Can't find aseembly.properties.attributes.parameter"))
                .First(x => (x.Element("Name") ?? throw new XmlException("Can't find assmembly.properties.attributes.paramenter.name")).Value == "Hinge2") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge2"))
                .Element("Value") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge2.value");

            Hinge3 = ((((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("Attributes") ?? throw new XmlException("Can't find assembly.properties.attributes"))
                .Descendants("Parameter") ?? throw new XmlException("Can't find aseembly.properties.attributes.parameter"))
                .First(x => (x.Element("Name") ?? throw new XmlException("Can't find assmembly.properties.attributes.paramenter.name")).Value == "Hinge3") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge3"))
                .Element("Value") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge3.value");

            Hinge4 = ((((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("Attributes") ?? throw new XmlException("Can't find assembly.properties.attributes"))
                .Descendants("Parameter") ?? throw new XmlException("Can't find aseembly.properties.attributes.parameter"))
                .First(x => (x.Element("Name") ?? throw new XmlException("Can't find assmembly.properties.attributes.paramenter.name")).Value == "Hinge4") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge4"))
                .Element("Value") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge4.value");

            Hinge5 = ((((doorAssemblyElement
                .Element("Properties") ?? throw new XmlException("Can't find assembly.properties"))
                .Element("Attributes") ?? throw new XmlException("Can't find assembly.properties.attributes"))
                .Descendants("Parameter") ?? throw new XmlException("Can't find aseembly.properties.attributes.parameter"))
                .First(x => (x.Element("Name") ?? throw new XmlException("Can't find assmembly.properties.attributes.paramenter.name")).Value == "Hinge5") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge5"))
                .Element("Value") ?? throw new XmlException("can't find assembly.properties.attributes.parameter.name attribute hinge5.value");

            XElement firstSection = ((doorAssemblyElement
                .Element("Sections") ?? throw new XmlException("Can't find assembly.sections"))
                .Elements("Section") ?? throw new XmlException("Can't find assembly.sections.section"))
                .ToArray<XElement>()[0] ?? throw new XmlException("There isn't a first element in array assebly.sections.section. Array is empty.");

            FirstSectionWidth = (((firstSection
                .Element("Face") ?? throw new XmlException("Can't find assembly.sections[0].section.face"))
                .Element("Dimensions") ?? throw new XmlException("Can't find assembly.sections[0].section.face.dimensions"))
                .Element("Width") ?? throw new XmlException("Can't find assembly.sections[0].section.face.dimensions.width"));

            FirstSectionHeight = (((firstSection
                .Element("Face") ?? throw new XmlException("Can't find assembly.sections[0].section.face"))
                .Element("Dimensions") ?? throw new XmlException("Can't find assembly.sections[0].section.face.dimensions"))
                .Element("Height") ?? throw new XmlException("Can't find assembly.sections[0].section.face.dimensions.height"));

            FirstSectionHingeLocation = ((firstSection
                .Element("Face") ?? throw new XmlException("Can't find assembly.sections[0].section.face"))
                .Element("Door") ?? throw new XmlException("Can't find assembly.sections[0].section.face.door"))
                .Element("Hinge") ?? throw new XmlException("Can't find assembly.sections[0].section.face.door.hinge");
            ;

            XElement secondSection = ((doorAssemblyElement
                .Element("Sections") ?? throw new XmlException("Can't find assembly.sections"))
                .Elements("Section") ?? throw new XmlException("Can't find assembly.sections.section"))
                .ToArray<XElement>()[1] ?? throw new XmlException("There isn't a second element in array assebly.sections.section. Array has 1 element.");


            SecondSectionWidth = (((secondSection
                .Element("Open") ?? throw new XmlException("Can't find assembly.sections[1].section.face"))
                .Element("Dimensions") ?? throw new XmlException("Can't find assembly.sections[1].section.face.dimensions"))
                .Element("Width") ?? throw new XmlException("Can't find assembly.sections[1].section.face.dimensions.width"));

            SecondSectionHeight = (((secondSection
                .Element("Open") ?? throw new XmlException("Can't find assembly.sections[1].section.face"))
                .Element("Dimensions") ?? throw new XmlException("Can't find assembly.sections[1].section.face.dimensions"))
                .Element("Height") ?? throw new XmlException("Can't find assembly.sections[1].section.face.dimensions.height"));
        }
    }
}
