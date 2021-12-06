using Amazon.Lambda.Core;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.SimpleEmail;
using Amazon.SimpleEmail.Model;
using MimeKit;
using System.Xml;
using System.Xml.Linq;

namespace CustomRuntimeListBucketsNET6
{
    internal class Ordx
    {
        const string _template = @"<?xml version=""1.0"" encoding=""UTF-8""?> 
<!-- Solid ORDX Order XML File -->
<Job Created=""1/11/2021 17:23:44"">
  <Unit>mm</Unit>
  <Properties>
    <Job>
      <Information>
        <Job>
          <Name>Job</Name>
          <Description>Default</Description></Job>
        
        </Information>
      <Attributes>
        <Parameter>
          <Name>CS_STYL</Name>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value></Parameter></Attributes></Job>
    <Room>
      <Finishes>
        <Finish>
          <Interior>System Bone</Interior>
          <Exterior>System Bone</Exterior></Finish>
        </Finishes>
      <Attributes>
        <Parameter>
          <Name>TOEH</Name>
          <Description>1.1 Toe Kick Height</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Equations count=""1"">
            <Equation>
              <IF>1</IF>
              <THEN>_CV:238</THEN></Equation></Equations>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>TOER</Name>
          <Description>1.2 Toe Kick Recess</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Equations count=""1"">
            <Equation>
              <IF>1</IF>
              <THEN>_CV:240</THEN></Equation></Equations>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FWP_LOCKS_NUM</Name>
          <Description>3.1 Locks: Default #</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FWP_LOCKS_ENABLE</Name>
          <Description>3.2 Locks: Enable All</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FWP_LOCKS_RESET</Name>
          <Description>3.2 Locks: Reset</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_Edit</Name>
          <Description>Adj Bore -Edit</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_Full</Name>
          <Description>Adj Bore -Full Hgt</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_DEP</Name>
          <Description>Adj Bore Depth (0)</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.472441</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_DIA</Name>
          <Description>Adj Bore Diameter (0)</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.19685</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_X_Bck</Name>
          <Description>Adj Bore Pos Bck (0)</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.456693</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_X_Fnt</Name>
          <Description>Adj Bore Pos Fnt (0)</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.456693</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_Y_Pos</Name>
          <Description>Adj Bore Pos Y</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_Y_Bot</Name>
          <Description>Adj Bore Pos Y Bot</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>3.937008</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_Y_Top</Name>
          <Description>Adj Bore Pos Y Top</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>3.937008</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_QTY</Name>
          <Description>Adj Bore QTY (0)</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>5</Value></Parameter>
        <Parameter>
          <Name>S_Room_Adj_SH_Bore_SPC</Name>
          <Description>Adj Bore Spacing</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.259843</Value></Parameter>
        <Parameter>
          <Name>S_Room_ArciTech_PTO</Name>
          <Description>ArciTech PTO</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_ArciTech_Rail</Name>
          <Description>ArciTech Rail Option</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""4"">
            <Choice>
              <Prompt>1 Rail</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>2 Rails</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>DesignSides</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>TopSides</Prompt>
              <Value>4</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Atira_Rail</Name>
          <Description>Atira Rail Option</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""4"">
            <Choice>
              <Prompt>1 Rail</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>2 Rails</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>TopSide Glass</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>TopSide Metal</Prompt>
              <Value>4</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Bench_Clip</Name>
          <Description>Bench Clip's</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Bench_Clip_Thru</Name>
          <Description>Bench Clip's Thru</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value></Parameter>
        <Parameter>
          <Name>S_Room_Blum_DF_Stabilizer</Name>
          <Description>Draw Blum DF Stabilizer</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_DFront_Holes</Name>
          <Description>Draw Front Holes</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_DFront_Screwon</Name>
          <Description>Draw Front Screwon</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Drill_All</Name>
          <Description>Drill Cabinet</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>10</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""8"">
            <Choice>
              <Prompt>Screw</Prompt>
              <Value>10</Value></Choice>
            <Choice>
              <Prompt>.None</Prompt>
              <Value>-2</Value></Choice>
            <Choice>
              <Prompt>Dowel</Prompt>
              <Value>13</Value></Choice>
            <Choice>
              <Prompt>Cam Type 1</Prompt>
              <Value>21</Value></Choice>
            <Choice>
              <Prompt>Cam Type 2</Prompt>
              <Value>22</Value></Choice>
            <Choice>
              <Prompt>Fastenlink</Prompt>
              <Value>30</Value></Choice>
            <Choice>
              <Prompt>User Defined 1</Prompt>
              <Value>51</Value></Choice>
            <Choice>
              <Prompt>User Defined 2</Prompt>
              <Value>52</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Drill_Fin</Name>
          <Description>Drill Finished Parts</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>21</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""8"">
            <Choice>
              <Prompt>Cam Type 1</Prompt>
              <Value>21</Value></Choice>
            <Choice>
              <Prompt>.None</Prompt>
              <Value>-2</Value></Choice>
            <Choice>
              <Prompt>Screw</Prompt>
              <Value>10</Value></Choice>
            <Choice>
              <Prompt>Dowel</Prompt>
              <Value>13</Value></Choice>
            <Choice>
              <Prompt>Cam Type 2</Prompt>
              <Value>22</Value></Choice>
            <Choice>
              <Prompt>Fastenlink</Prompt>
              <Value>30</Value></Choice>
            <Choice>
              <Prompt>User Defined 1</Prompt>
              <Value>51</Value></Choice>
            <Choice>
              <Prompt>User Defined 2</Prompt>
              <Value>52</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>FPEdit</Name>
          <Description>FP 0 Edit</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FPTG</Name>
          <Description>FP 1 Top Gap</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FPMG</Name>
          <Description>FP 2 Mid Gap</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FPD</Name>
          <Description>FP 3 Depth</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.728346</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FPUL</Name>
          <Description>FP 4 Up Lip</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>FPBL</Name>
          <Description>FP 5 Bot Lip</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.19685</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel</Name>
          <Description>Fpulls Mel</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Edit</Name>
          <Description>Fpulls Mel -Edit</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Cnr_Sqr</Name>
          <Description>Fpulls Mel Cnr Square</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Gap_Top</Name>
          <Description>Fpulls Mel Gap  Top</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Gap_Mid</Name>
          <Description>Fpulls Mel Gap Mid</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Lip_Top</Name>
          <Description>Fpulls Mel Lip  Top</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Lip_Bot</Name>
          <Description>Fpulls Mel Lip Bot</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Lip_Mid_Top</Name>
          <Description>Fpulls Mel Lip Mid Top</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.181102</Value></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mitre_On</Name>
          <Description>Fpulls Mel Mitres</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Choices count=""3"">
            <Choice>
              <Prompt>.Off</Prompt>
              <Value>0</Value></Choice>
            <Choice>
              <Prompt>Mitre Tool 1</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Mitre Tool 2</Prompt>
              <Value>2</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Fpull_Mel_Depth</Name>
          <Description>Fpulls Mel Route Depth</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.728346</Value></Parameter>
        <Parameter>
          <Name>S_Room_Hafele_Buffers</Name>
          <Description>Hafele Buffers</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""4"">
            <Choice>
              <Prompt>.Off</Prompt>
              <Value>0</Value></Choice>
            <Choice>
              <Prompt>Doors</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Drawers</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Both</Prompt>
              <Value>3</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Handle_Holes</Name>
          <Description>Handle Holes</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Handle_Holes_DZ</Name>
          <Description>Handle Holes Depth</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.629921</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Handles_Edit</Name>
          <Description>Handles -Edit</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Handles_CTR</Name>
          <Description>Handles Center</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_DRW_CTR</Name>
          <Description>Handles Draw Ctr</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_DRW_POS</Name>
          <Description>Handles Draw Pos</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.968504</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_POS_H</Name>
          <Description>Handles Pos Horiz</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.968504</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_POS_V</Name>
          <Description>Handles Pos Vert</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1.968504</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_TALL_POS</Name>
          <Description>Handles Tall Pos</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>34.645669</Value></Parameter>
        <Parameter>
          <Name>S_Room_Handles_Vertical</Name>
          <Description>Handles Vertical</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value></Parameter>
        <Parameter>
          <Name>S_Room_Hinge_Cups</Name>
          <Description>Hinge Cup Holes</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Hinge_Pos</Name>
          <Description>Hinge Position</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>5.03937</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>zRoomLabelShiftReset</Name>
          <Description>Label Shift Reset</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_LBox_Fronts_3a</Name>
          <Description>Legrabox Fronts Option 3a</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_LBox_Inner_Fnt</Name>
          <Description>Legrabox Inner Fronts</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""3"">
            <Choice>
              <Prompt>Gallery</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>High Element</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Low Element</Prompt>
              <Value>3</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_HAFMX_Rail</Name>
          <Description>MX Rail Option</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""4"">
            <Choice>
              <Prompt>1 Round Rail</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>2 Rect Rail</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>3 Side Panel</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>4 Side Glass</Prompt>
              <Value>4</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Panel_Outset</Name>
          <Description>Panel Outset =</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0.708661</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Plastic_Leg_Cen_Hole_Dia</Name>
          <Description>Plastic Leg Cen Hole Diam</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Plastic_Leg_Holes</Name>
          <Description>Plastic Leg Holes</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Plastic_Legs</Name>
          <Description>Plastic Legs</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Edit</Name>
          <Description>Rails -Edit</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Bck_Type</Name>
          <Description>Rails Back</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Choices count=""5"">
            <Choice>
              <Prompt>Standard Horizontal</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Standard Vertical</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Timber Horizontal</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>Timber Vertical</Prompt>
              <Value>4</Value></Choice>
            <Choice>
              <Prompt>None</Prompt>
              <Value>0</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Bck_Width_H</Name>
          <Description>Rails Back Width -H</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Equations count=""1"">
            <Equation>
              <IF>1</IF>
              <THEN>_CV:147</THEN></Equation></Equations></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Bck_Width_V</Name>
          <Description>Rails Back Width -V</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>2.362205</Value></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Fnt_Type</Name>
          <Description>Rails Front</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Choices count=""5"">
            <Choice>
              <Prompt>Standard Horizontal</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Standard Vertical</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Timber Horizontal</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>Timber Vertical</Prompt>
              <Value>4</Value></Choice>
            <Choice>
              <Prompt>None</Prompt>
              <Value>0</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Fnt_Width_H</Name>
          <Description>Rails Front Width -H</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Equations count=""1"">
            <Equation>
              <IF>1</IF>
              <THEN>_CV:146</THEN></Equation></Equations></Parameter>
        <Parameter>
          <Name>S_Room_Rails_Fnt_Width_V</Name>
          <Description>Rails Front Width -V</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>2.362205</Value></Parameter>
        <Parameter>
          <Name>S_Room_Npsc_Back_Holes</Name>
          <Description>Scala Back Holes</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""3"">
            <Choice>
              <Prompt>Screwon</Prompt>
              <Value>0</Value></Choice>
            <Choice>
              <Prompt>Lugs</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Screws and Lugs</Prompt>
              <Value>2</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Npsc_Tipmatic</Name>
          <Description>Scala Tipmatic</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>S_Room_Shelf_Pin_Type</Name>
          <Description>Shelf Pin  Type</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""4"">
            <Choice>
              <Prompt>Standard</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Rebated</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Lug</Prompt>
              <Value>3</Value></Choice>
            <Choice>
              <Prompt>.None</Prompt>
              <Value>0</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_Shelf_Pin_Mat</Name>
          <Description>Shelf Pin Material</Description>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
          <Choices count=""3"">
            <Choice>
              <Prompt>Plastic</Prompt>
              <Value>1</Value></Choice>
            <Choice>
              <Prompt>Steel</Prompt>
              <Value>2</Value></Choice>
            <Choice>
              <Prompt>Brass</Prompt>
              <Value>3</Value></Choice></Choices></Parameter>
        <Parameter>
          <Name>S_Room_System_Dadoes</Name>
          <Description>System Dadoes</Description>
          <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>WFP</Name>
          <Description>Wall Finger Pull</Description>
          <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>0</Value>
          <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
        <Parameter>
          <Name>ROOM</Name>
          <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
          <Value>1</Value></Parameter></Attributes></Room>
    <Cabinet>
      <Construction>
        <Cabinet>MT HQ Standard 2a</Cabinet>
        <DrawerBox>Blum Antaro Drawer</DrawerBox>
        <RollOut>Blum Antaro Inner</RollOut></Construction>
      <Materials>
        <BaseMaterialSchedules>
          <Standard>INT CP1 16mm 1mm Edge</Standard>
          <ExposedInterior>INT CP1 16mm 1mm Edge</ExposedInterior></BaseMaterialSchedules>
        <UpperMaterialSchedules>
          <Standard>INT CP1 16mm 1mm Edge</Standard>
          <ExposedInterior>INT CP1 16mm 1mm Edge</ExposedInterior></UpperMaterialSchedules>
        <DrawerBox>16mm White 1mm Edge</DrawerBox>
        <RollOut>16mm White 1mm Edge</RollOut></Materials>
      <Hardware>
        <PullSchedule>No Pulls/Knobs</PullSchedule>
        <HingeSchedule>Blum ClipTop W5 Inserta</HingeSchedule>
        <GuideSchedule>Blum Antaro(AU) Wte Bmtn 30K</GuideSchedule>
        <SlidingDoorRailSchedule>Sliding Door Rail</SlidingDoorRailSchedule></Hardware>
      <Doors>
        <All>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></All>
        <Base>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></Base>
        <Drawer>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></Drawer>
        <Upper>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></Upper>
        <BaseEP>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></BaseEP>
        <UpperEP>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></UpperEP>
        <TallEP>
          <Style>Slab</Style>
          <Material>HMR White 16mm 1mm Edge</Material>
          <Catalog>door.ddb</Catalog></TallEP></Doors></Cabinet>
    <Closets>
      
      
      
      </Closets>
    <Molding>
      <Material>Moulding</Material>
      <Crown>Crown Moldings</Crown>
      <LightRail>Square 9x50</LightRail>
      <Scribe>Scribe 500 5x44</Scribe>
      <BaseBoard>Base 303 11x57</BaseBoard>
      <ChairRail>CR 200 16x63</ChairRail>
      <Casing>Chair Rails</Casing>
      <Ceiling>Ceiling 19x44</Ceiling></Molding></Properties>
  <Rooms>
    <Room>
      <Perspective></Perspective>
      <RoomProperties>
        <Room>
          <General>
            <Name>Room 1</Name>
            <Description>Room</Description>
            <Type>Room</Type><!--Room|Project|Plan|FloorLevel|Phase-->
            <Material> Default</Material></General>
          
          <Parameters>
            <Parameter>
              <Name>TOEH</Name>
              <Description>1.1 Toe Kick Height</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Equations count=""1"">
                <Equation>
                  <IF>1</IF>
                  <THEN>_CV:238</THEN></Equation></Equations>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>TOER</Name>
              <Description>1.2 Toe Kick Recess</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Equations count=""1"">
                <Equation>
                  <IF>1</IF>
                  <THEN>_CV:240</THEN></Equation></Equations>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FWP_LOCKS_NUM</Name>
              <Description>3.1 Locks: Default #</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FWP_LOCKS_ENABLE</Name>
              <Description>3.2 Locks: Enable All</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FWP_LOCKS_RESET</Name>
              <Description>3.2 Locks: Reset</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_Edit</Name>
              <Description>Adj Bore -Edit</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_Full</Name>
              <Description>Adj Bore -Full Hgt</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_DEP</Name>
              <Description>Adj Bore Depth (0)</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.472441</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_DIA</Name>
              <Description>Adj Bore Diameter (0)</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.19685</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_X_Bck</Name>
              <Description>Adj Bore Pos Bck (0)</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.456693</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_X_Fnt</Name>
              <Description>Adj Bore Pos Fnt (0)</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.456693</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_Y_Pos</Name>
              <Description>Adj Bore Pos Y</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_Y_Bot</Name>
              <Description>Adj Bore Pos Y Bot</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>3.937008</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_Y_Top</Name>
              <Description>Adj Bore Pos Y Top</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>3.937008</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_QTY</Name>
              <Description>Adj Bore QTY (0)</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>5</Value></Parameter>
            <Parameter>
              <Name>S_Room_Adj_SH_Bore_SPC</Name>
              <Description>Adj Bore Spacing</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.259843</Value></Parameter>
            <Parameter>
              <Name>S_Room_ArciTech_PTO</Name>
              <Description>ArciTech PTO</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_ArciTech_Rail</Name>
              <Description>ArciTech Rail Option</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""4"">
                <Choice>
                  <Prompt>1 Rail</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>2 Rails</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>DesignSides</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>TopSides</Prompt>
                  <Value>4</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Atira_Rail</Name>
              <Description>Atira Rail Option</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""4"">
                <Choice>
                  <Prompt>1 Rail</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>2 Rails</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>TopSide Glass</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>TopSide Metal</Prompt>
                  <Value>4</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Bench_Clip</Name>
              <Description>Bench Clip's</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Bench_Clip_Thru</Name>
              <Description>Bench Clip's Thru</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value></Parameter>
            <Parameter>
              <Name>S_Room_Blum_DF_Stabilizer</Name>
              <Description>Draw Blum DF Stabilizer</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_DFront_Holes</Name>
              <Description>Draw Front Holes</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_DFront_Screwon</Name>
              <Description>Draw Front Screwon</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Drill_All</Name>
              <Description>Drill Cabinet</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>10</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""8"">
                <Choice>
                  <Prompt>Screw</Prompt>
                  <Value>10</Value></Choice>
                <Choice>
                  <Prompt>.None</Prompt>
                  <Value>-2</Value></Choice>
                <Choice>
                  <Prompt>Dowel</Prompt>
                  <Value>13</Value></Choice>
                <Choice>
                  <Prompt>Cam Type 1</Prompt>
                  <Value>21</Value></Choice>
                <Choice>
                  <Prompt>Cam Type 2</Prompt>
                  <Value>22</Value></Choice>
                <Choice>
                  <Prompt>Fastenlink</Prompt>
                  <Value>30</Value></Choice>
                <Choice>
                  <Prompt>User Defined 1</Prompt>
                  <Value>51</Value></Choice>
                <Choice>
                  <Prompt>User Defined 2</Prompt>
                  <Value>52</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Drill_Fin</Name>
              <Description>Drill Finished Parts</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>21</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""8"">
                <Choice>
                  <Prompt>Cam Type 1</Prompt>
                  <Value>21</Value></Choice>
                <Choice>
                  <Prompt>.None</Prompt>
                  <Value>-2</Value></Choice>
                <Choice>
                  <Prompt>Screw</Prompt>
                  <Value>10</Value></Choice>
                <Choice>
                  <Prompt>Dowel</Prompt>
                  <Value>13</Value></Choice>
                <Choice>
                  <Prompt>Cam Type 2</Prompt>
                  <Value>22</Value></Choice>
                <Choice>
                  <Prompt>Fastenlink</Prompt>
                  <Value>30</Value></Choice>
                <Choice>
                  <Prompt>User Defined 1</Prompt>
                  <Value>51</Value></Choice>
                <Choice>
                  <Prompt>User Defined 2</Prompt>
                  <Value>52</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>FPEdit</Name>
              <Description>FP 0 Edit</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FPTG</Name>
              <Description>FP 1 Top Gap</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FPMG</Name>
              <Description>FP 2 Mid Gap</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FPD</Name>
              <Description>FP 3 Depth</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.728346</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FPUL</Name>
              <Description>FP 4 Up Lip</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>FPBL</Name>
              <Description>FP 5 Bot Lip</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.19685</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel</Name>
              <Description>Fpulls Mel</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Edit</Name>
              <Description>Fpulls Mel -Edit</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Cnr_Sqr</Name>
              <Description>Fpulls Mel Cnr Square</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Gap_Top</Name>
              <Description>Fpulls Mel Gap  Top</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Gap_Mid</Name>
              <Description>Fpulls Mel Gap Mid</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Lip_Top</Name>
              <Description>Fpulls Mel Lip  Top</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Lip_Bot</Name>
              <Description>Fpulls Mel Lip Bot</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Lip_Mid_Top</Name>
              <Description>Fpulls Mel Lip Mid Top</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.181102</Value></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mitre_On</Name>
              <Description>Fpulls Mel Mitres</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Choices count=""3"">
                <Choice>
                  <Prompt>.Off</Prompt>
                  <Value>0</Value></Choice>
                <Choice>
                  <Prompt>Mitre Tool 1</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Mitre Tool 2</Prompt>
                  <Value>2</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Fpull_Mel_Depth</Name>
              <Description>Fpulls Mel Route Depth</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.728346</Value></Parameter>
            <Parameter>
              <Name>S_Room_Hafele_Buffers</Name>
              <Description>Hafele Buffers</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""4"">
                <Choice>
                  <Prompt>.Off</Prompt>
                  <Value>0</Value></Choice>
                <Choice>
                  <Prompt>Doors</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Drawers</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Both</Prompt>
                  <Value>3</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Handle_Holes</Name>
              <Description>Handle Holes</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Handle_Holes_DZ</Name>
              <Description>Handle Holes Depth</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.629921</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Handles_Edit</Name>
              <Description>Handles -Edit</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Handles_CTR</Name>
              <Description>Handles Center</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_DRW_CTR</Name>
              <Description>Handles Draw Ctr</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_DRW_POS</Name>
              <Description>Handles Draw Pos</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.968504</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_POS_H</Name>
              <Description>Handles Pos Horiz</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.968504</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_POS_V</Name>
              <Description>Handles Pos Vert</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1.968504</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_TALL_POS</Name>
              <Description>Handles Tall Pos</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>34.645669</Value></Parameter>
            <Parameter>
              <Name>S_Room_Handles_Vertical</Name>
              <Description>Handles Vertical</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value></Parameter>
            <Parameter>
              <Name>S_Room_Hinge_Cups</Name>
              <Description>Hinge Cup Holes</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Hinge_Pos</Name>
              <Description>Hinge Position</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>5.03937</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>zRoomLabelShiftReset</Name>
              <Description>Label Shift Reset</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_LBox_Fronts_3a</Name>
              <Description>Legrabox Fronts Option 3a</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_LBox_Inner_Fnt</Name>
              <Description>Legrabox Inner Fronts</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""3"">
                <Choice>
                  <Prompt>Gallery</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>High Element</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Low Element</Prompt>
                  <Value>3</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_HAFMX_Rail</Name>
              <Description>MX Rail Option</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""4"">
                <Choice>
                  <Prompt>1 Round Rail</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>2 Rect Rail</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>3 Side Panel</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>4 Side Glass</Prompt>
                  <Value>4</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Panel_Outset</Name>
              <Description>Panel Outset =</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0.708661</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Plastic_Leg_Cen_Hole_Dia</Name>
              <Description>Plastic Leg Cen Hole Diam</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Plastic_Leg_Holes</Name>
              <Description>Plastic Leg Holes</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Plastic_Legs</Name>
              <Description>Plastic Legs</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Edit</Name>
              <Description>Rails -Edit</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Bck_Type</Name>
              <Description>Rails Back</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Choices count=""5"">
                <Choice>
                  <Prompt>Standard Horizontal</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Standard Vertical</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Timber Horizontal</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>Timber Vertical</Prompt>
                  <Value>4</Value></Choice>
                <Choice>
                  <Prompt>None</Prompt>
                  <Value>0</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Bck_Width_H</Name>
              <Description>Rails Back Width -H</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Equations count=""1"">
                <Equation>
                  <IF>1</IF>
                  <THEN>_CV:147</THEN></Equation></Equations></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Bck_Width_V</Name>
              <Description>Rails Back Width -V</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>2.362205</Value></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Fnt_Type</Name>
              <Description>Rails Front</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Choices count=""5"">
                <Choice>
                  <Prompt>Standard Horizontal</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Standard Vertical</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Timber Horizontal</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>Timber Vertical</Prompt>
                  <Value>4</Value></Choice>
                <Choice>
                  <Prompt>None</Prompt>
                  <Value>0</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Fnt_Width_H</Name>
              <Description>Rails Front Width -H</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Equations count=""1"">
                <Equation>
                  <IF>1</IF>
                  <THEN>_CV:146</THEN></Equation></Equations></Parameter>
            <Parameter>
              <Name>S_Room_Rails_Fnt_Width_V</Name>
              <Description>Rails Front Width -V</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>2.362205</Value></Parameter>
            <Parameter>
              <Name>S_Room_Npsc_Back_Holes</Name>
              <Description>Scala Back Holes</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""3"">
                <Choice>
                  <Prompt>Screwon</Prompt>
                  <Value>0</Value></Choice>
                <Choice>
                  <Prompt>Lugs</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Screws and Lugs</Prompt>
                  <Value>2</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Npsc_Tipmatic</Name>
              <Description>Scala Tipmatic</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Note</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>S_Room_Shelf_Pin_Type</Name>
              <Description>Shelf Pin  Type</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""4"">
                <Choice>
                  <Prompt>Standard</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Rebated</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Lug</Prompt>
                  <Value>3</Value></Choice>
                <Choice>
                  <Prompt>.None</Prompt>
                  <Value>0</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_Shelf_Pin_Mat</Name>
              <Description>Shelf Pin Material</Description>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing-->
              <Choices count=""3"">
                <Choice>
                  <Prompt>Plastic</Prompt>
                  <Value>1</Value></Choice>
                <Choice>
                  <Prompt>Steel</Prompt>
                  <Value>2</Value></Choice>
                <Choice>
                  <Prompt>Brass</Prompt>
                  <Value>3</Value></Choice></Choices></Parameter>
            <Parameter>
              <Name>S_Room_System_Dadoes</Name>
              <Description>System Dadoes</Description>
              <Type>B</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>WFP</Name>
              <Description>Wall Finger Pull</Description>
              <Type>M</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>0</Value>
              <Style>Attribute</Style><!--Attribute|Note|Standard *standard is default if missing--></Parameter>
            <Parameter>
              <Name>ROOM</Name>
              <Type>I</Type><!--Measurement|Meas|M|Degrees|Deg|D|Integer|Int|I|Boolean|Bool|B|Decimal|Dec|D|Text|T|Currency|Cur|C-->
              <Value>1</Value></Parameter></Parameters></Room>
        <Cabinet>
          
          
          
          </Cabinet>
        <Closets>
          
          
          
          </Closets>
        </RoomProperties>
      <Walls>
        <Wall>
          <Number>1</Number>
          <Description>Wall 1</Description>
          <Position>
            <StartX>-3353.720</StartX>
            <StartY>-1124.039</StartY><!--EndX, EndY are optional, if present they will override wall length-->
            <EndX>1771.603</EndX>
            <EndY>-1124.039</EndY></Position>
          <Type>
            <Style>Standard</Style><!--Standard|Peninsula|Cathedral|VaultLeft|VaultRight--></Type>
          <Dimensions>
            <Length>5125.323</Length>
            <Height>2438.400</Height>
            <Soffit>304.800</Soffit>
            <Thick>114.300</Thick>
            <VaultHeight>1219.200</VaultHeight></Dimensions>
          <Assemblies>
          </Assemblies>
        </Wall>
      </Walls>
    </Room>
  </Rooms>
</Job>";
        private XElement? _doc;
        public Ordx()
        {
            _doc = XElement.Parse(_template);
        }
        public Ordx AddDoor(Door door)
        {
            if (_doc == null) throw new NullReferenceException("You must call Load to load a document first");
            if (door == null) throw new ArgumentNullException(nameof(door), "Door to be added can't be null");
            XElement assemblies = ((((_doc
                .Element("Rooms") ?? throw new XmlException("Can't find jobs.rooms"))
                .Element("Room") ?? throw new XmlException("Can't find jobs.rooms.room"))
                .Element("Walls") ?? throw new XmlException("Can't find jobs.rooms.room.walls"))
                .Element("Wall") ?? throw new XmlException("Cant'f find jobs rooms.room.walls.wall"))
                .Element("Assemblies") ?? throw new XmlException("Can't find jobs.rooms.room.walls.wall.assemblies");

            XElement wall = (((_doc
                    .Element("Rooms") ?? throw new XmlException("Can't find jobs.rooms"))
                    .Element("Room") ?? throw new XmlException("Can't find jobs.rooms.room"))
                    .Element("Walls") ?? throw new XmlException("Can't find jobs.rooms.room.walls"))
                    .Element("Wall") ?? throw new XmlException("Cant'f find jobs rooms.room.walls.wall");

            door.SetPositionOnWall(assemblies, wall);

            XElement doorXElement = door.CreateXElement();
            assemblies.Add(doorXElement);

            return this;
        }


        public async Task<PutObjectResponse> SaveAsync(ILambdaLogger logger)
        {
            if (_doc == null) throw new NullReferenceException("You must call Load to load a document first");

            PutObjectResponse response = null;

            try
            {
                using (var client = new AmazonS3Client())
                {
                    var request = new PutObjectRequest
                    {
                        BucketName = "ordxstore",
                        Key = $"{Guid.NewGuid().ToString()}.ordx",
                        ContentBody = _doc.ToString(),
                        ContentType = "application/xml"
                    };

                    response = await client.PutObjectAsync(request);



                }
            }
            catch (Exception ex)
            {
                logger.LogError(ex.Message);
            }


            return response;
        }

        public async Task<SendRawEmailResponse> EmailAsync(ILambdaLogger logger)
        {
            SendRawEmailResponse response = null;
            using (var client = new AmazonSimpleEmailServiceClient())
            {

                string senderAddress = "office@zippy.solutions";

                string receiverAddress = "liviu@zippy.solutions";
                string subject = "New order";

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = "New order :)";
                bodyBuilder.TextBody = "New order :)";
                using (var memoryStream = new MemoryStream())
                {
                    _doc.Save(memoryStream);
                    memoryStream.Position = 0;
                    bodyBuilder.Attachments.Add("order.ordx", memoryStream);
                }

                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(MailboxAddress.Parse(senderAddress));
                mimeMessage.To.Add(MailboxAddress.Parse(receiverAddress));
//                mimeMessage.To.Add(MailboxAddress.Parse("bogdan.mihaesi@gmail.com"));
                mimeMessage.Subject = subject;
                mimeMessage.Body = bodyBuilder.ToMessageBody();

                using (var memoryStream = new MemoryStream())
                {
                    await mimeMessage.WriteToAsync(memoryStream);
                    var sendRequest = new SendRawEmailRequest
                    {
                        RawMessage = new RawMessage(memoryStream)
                    };
                    try
                    {
                        logger.LogTrace("Sending email using Amazon SES...");
                        response = await client.SendRawEmailAsync(sendRequest);
                        logger.LogTrace("The email was sent successfully.");
                    }
                    catch (Exception ex)
                    {
                        logger.LogTrace("The email was not sent.");
                        logger.LogError("Error message: " + ex.Message);

                    }
                }
            }

            return response;
        }
    }
}

