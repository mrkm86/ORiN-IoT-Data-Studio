<?xml version="1.0" encoding="utf-8"?>
<INode xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Object="True" Type="clsCaoSQLController" Name="【SK】TCPIP">
  <Expanded>True</Expanded>
  <Key VT="8">【SK】TCPIP</Key>
  <Selected>False</Selected>
  <clsCaoSQLController Object="True" Property="Tag">
    <m_strProvider VT="8">CaoProv.DNWA.STREAM</m_strProvider>
    <m_strMachine VT="8" />
    <m_strCtrlName VT="8">TCPIP</m_strCtrlName>
    <m_strParam VT="8">conn=eth:127.0.0.1:65000, EtherOpt=1:5</m_strParam>
    <m_lSamplingRate>300</m_lSamplingRate>
    <m_bDistribute>False</m_bDistribute>
    <m_bDescription>True</m_bDescription>
    <m_strDescription VT="8" />
    <m_bEnabled>True</m_bEnabled>
    <m_lImageIndex>1</m_lImageIndex>
    <m_bStartup>True</m_bStartup>
    <m_bUseHistory>True</m_bUseHistory>
    <m_lPriority>3</m_lPriority>
    <m_lType>0</m_lType>
    <m_lTimeStamp>2</m_lTimeStamp>
    <m_bWriteToCache>False</m_bWriteToCache>
    <m_bVariableSync>False</m_bVariableSync>
    <m_bWDT>False</m_bWDT>
    <m_lWDTCount>3</m_lWDTCount>
    <m_bWDTDS>False</m_bWDTDS>
    <m_lWDTTime>0</m_lWDTTime>
    <m_lWDTAction>0</m_lWDTAction>
    <m_bUseTrigger>False</m_bUseTrigger>
    <m_bTriggerDisable>False</m_bTriggerDisable>
    <m_bCalcDisable>True</m_bCalcDisable>
    <Collection Object="True" Property="m_mapTrigger">
      <clsCaoSQLTriggerItem Object="True" Index="1">
        <m_strName />
        <clsCaoSQLTriggerInfo Object="True" Index="1">
          <m_lAction>0</m_lAction>
          <m_strExeFile VT="8" />
          <m_strExeParams VT="8" />
          <m_lCondition>-1</m_lCondition>
          <m_strThreshold VT="8" />
        </clsCaoSQLTriggerInfo>
        <clsCaoSQLTriggerInfo Object="True" Index="2">
          <m_lAction>0</m_lAction>
          <m_strExeFile VT="8" />
          <m_strExeParams VT="8" />
          <m_lCondition>-1</m_lCondition>
          <m_strThreshold VT="8" />
        </clsCaoSQLTriggerInfo>
        <NewEnum />
        <Count>2</Count>
      </clsCaoSQLTriggerItem>
    </Collection>
    <TriggerEx>
      <m_bEnabled>True</m_bEnabled>
      <m_lId>0</m_lId>
      <Evaluation>
        <m_bEnabled>True</m_bEnabled>
        <m_strName />
        <m_lCondition>12</m_lCondition>
        <m_strThreshold />
        <m_bPrevValue>0</m_bPrevValue>
        <m_lConjunction>0</m_lConjunction>
        <Description VT="8">受信</Description>
        <m_lId>1</m_lId>
        <Action>
          <m_lId>2</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>1</m_lCallback>
          <Description VT="8">新しいアクション</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">E6MSLJDZ3AYH0L1P6ZCDDPMBR2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>DebugPrintPlugin.DebugPrint</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>DebugPrintAction.DebugPrint</Value>
            </Data>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】TCPIP</Value>
            </Data>
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>3</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】コントローラ名取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_NAME").Value = "TCPIP"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">QUF09UNZRM9U30F7E7C69NWN32</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>4</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">FFMFVGJGXO7V189322XY97WWJ2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>5</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理開始</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理開始"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">6K707VNAIBY71LONXJQ5J5U4M2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>6</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">FLKS3OSIFB0931BK9XYDLT4ZZ1</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>7</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>8</m_lAction>
          <m_lCallback />
          <m_strPutItem VT="8">[value]T_DATA</m_strPutItem>
          <m_strPutValue VT="8">Value</m_strPutValue>
          <Description VT="8">【Action】TCPIPデータ受信</Description>
          <m_strScript />
          <m_bNotSafeMode />
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">PBU7WNODWOBX1OVRNFIQX5AIM2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>8</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">P4Q4TQ8VTGG61BNJX64MYOVTT2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>9</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutItem VT="8">[LogData]T_LOGDATA</m_strPutItem>
          <m_strPutValue VT="8">[value]T_DATA</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】DATA - TCPIPデータ取得</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">9HQ13IUKW7FI1KHLUG0DJJUP22</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>10</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">D3PTY0YT0HIC2G5TXSTFDDOHI2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>11</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">2KV2INMWOR4D1E7O64MJCND702</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>12</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理終了</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "テキストファイルへ出力"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">L8X85O6EETPC1J0GF6G3ZO7QN2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>13</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>2</m_lCallback>
          <Description VT="8">【Action】テキストファイルへ出力</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">HATGVGXVVI6S0IYE0KF47X3RJ2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>CSVPlugin.CSVOutput</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>CSVOutputAction.CSVOutput</Value>
            </Data>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】TCPIP</Value>
            </Data>
            <Data>
              <Key>Folder</Key>
              <Value>C:\IoT STARTER\Data\TCPIP\RECV</Value>
            </Data>
            <Data>
              <Key>FileName</Key>
              <Value>{SYSDATE:yyyyMMddHHmmss}.txt</Value>
            </Data>
            <Data>
              <Key>WriteMode</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>_Async</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>MaxLinesOn</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>MaxLines</Key>
              <Value>100</Value>
            </Data>
            <Data>
              <Key>MaxSizeOn</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>MaxSize</Key>
              <Value>100</Value>
            </Data>
            <Data>
              <Key>SizeUnit</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>StopWritingOn</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>Encoding</Key>
              <Value>utf-8*</Value>
            </Data>
            <Data>
              <Key>OutputHeader</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>Separator</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>LineFeed</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>Quote</Key>
              <Value>2</Value>
            </Data>
            <Data>
              <Key>EndWithLineFeed</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>WriteFileName</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>PrevFolderName</Key>
              <Value />
            </Data>
            <Data>
              <Key>PrevFileName</Key>
              <Value />
            </Data>
            <Data>
              <Key>CurrentFolderItem</Key>
              <Value />
            </Data>
            <Data>
              <Key>CurrentFileItem</Key>
              <Value />
            </Data>
            <Data>
              <Key>CloseEachWrite</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>Data</Key>
              <Data>
                <Key>Header</Key>
                <Value>T_DATA</Value>
              </Data>
              <Data>
                <Key>Item</Key>
                <Value>【SK】TCPIP\[value]T_DATA</Value>
              </Data>
              <Data>
                <Key>Property</Key>
                <Value>Value</Value>
              </Data>
            </Data>
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>14</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">WNJ3V2840OBS2JCWDZ1S8K42L2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>15</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">MDI9WWA45YDQ1DMESYSR1UCJA2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>16</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理終了</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理終了"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">E9JRO4LSNWOH0BT2OUI7DL3GB2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>17</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">YXCVPM2H0SAG2DI1CFLWL0ARH2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Else />
      </Evaluation>
    </TriggerEx>
    <m_bAutoReconn>True</m_bAutoReconn>
    <m_lRecCount>10</m_lRecCount>
    <m_lRecInterval>2</m_lRecInterval>
    <m_bScript>False</m_bScript>
    <m_strScript />
    <m_bNotSafeMode>False</m_bNotSafeMode>
    <ClassAttribute>1</ClassAttribute>
    <RSQLCtrlName VT="8">【SK】TCPIP</RSQLCtrlName>
    <m_bEventBinding>True</m_bEventBinding>
    <m_bOutputActionLog>False</m_bOutputActionLog>
    <IsRemoteController>false</IsRemoteController>
    <m_lRecWaitTime>5</m_lRecWaitTime>
    <m_lRecType>0</m_lRecType>
    <IsSystemController>false</IsSystemController>
    <IsVirtualController>false</IsVirtualController>
  </clsCaoSQLController>
  <Text VT="8">【SK】TCPIP</Text>
  <BackColor>2147483653</BackColor>
  <Checked>False</Checked>
  <ForeColor>2147483656</ForeColor>
  <INode Object="True" Type="clsCaoSQLGroup" Name="value">
    <Expanded>True</Expanded>
    <Key VT="8">【SK】TCPIP\value</Key>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">value</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_DATA">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】TCPIP\value\T_DATA</Key>
      <Selected>True</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">T_DATA</m_strVarName>
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName VT="8" />
        <m_strSysObjOption VT="8" />
        <m_bDescription>True</m_bDescription>
        <m_strDescription VT="8" />
        <m_bUseHistory>True</m_bUseHistory>
        <m_bUseEmpty>False</m_bUseEmpty>
        <m_bEnabled>True</m_bEnabled>
        <m_lImageIndex>2</m_lImageIndex>
        <m_bOnChangeEvent>False</m_bOnChangeEvent>
        <m_lType>0</m_lType>
        <m_bDeactivate>False</m_bDeactivate>
        <m_bDeadBand>False</m_bDeadBand>
        <m_fDeadBandMin>0</m_fDeadBandMin>
        <m_fDeadBandMax>0</m_fDeadBandMax>
        <m_bMinMax>False</m_bMinMax>
        <m_fMin>0</m_fMin>
        <m_fMax>0</m_fMax>
        <m_bChatEnabled>False</m_bChatEnabled>
        <m_lChatMax>0</m_lChatMax>
        <m_strDefaultValue VT="8" />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem VT="8" />
        <m_str3rdItem VT="8" />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>9</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[value]T_DATA</m_strItemName>
        <m_strCtrlName VT="8">【SK】TCPIP</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】TCPIP\value\T_DATA</FullName>
        <LinkItem VT="8" />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
      </clsCaoSQLItem>
      <Text VT="8">T_DATA</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
  <INode Object="True" Type="clsCaoSQLGroup" Name="LogData">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】TCPIP\LogData</Key>
    <Previous>value</Previous>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">LogData</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="ArrayLogData">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】TCPIP\LogData\ArrayLogData</Key>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8" />
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName VT="8" />
        <m_strSysObjOption VT="8" />
        <m_bDescription>True</m_bDescription>
        <m_strDescription VT="8" />
        <m_bUseHistory>True</m_bUseHistory>
        <m_bUseEmpty>False</m_bUseEmpty>
        <m_bEnabled>True</m_bEnabled>
        <m_lImageIndex>27</m_lImageIndex>
        <m_bOnChangeEvent>True</m_bOnChangeEvent>
        <m_lType>2</m_lType>
        <m_bDeactivate>False</m_bDeactivate>
        <m_bDeadBand>False</m_bDeadBand>
        <m_fDeadBandMin>0</m_fDeadBandMin>
        <m_fDeadBandMax>0</m_fDeadBandMax>
        <m_bMinMax>False</m_bMinMax>
        <m_fMin>0</m_fMin>
        <m_fMax>0</m_fMax>
        <m_bChatEnabled>False</m_bChatEnabled>
        <m_lChatMax>0</m_lChatMax>
        <m_strDefaultValue VT="8" />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem VT="8" />
        <m_str3rdItem VT="8" />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>True</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]ArrayLogData</m_strItemName>
        <m_strCtrlName VT="8">【SK】TCPIP</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】TCPIP\LogData\ArrayLogData</FullName>
        <LinkItem VT="8">[LogData]T_TIME,[LogData]T_NAME,[LogData]T_LOGDATA</LinkItem>
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
      </clsCaoSQLItem>
      <Text VT="8">ArrayLogData</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_TIME">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】TCPIP\LogData\T_TIME</Key>
      <Previous>ArrayLogData</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">T_TIME</m_strVarName>
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName VT="8" />
        <m_strSysObjOption VT="8" />
        <m_bDescription>True</m_bDescription>
        <m_strDescription VT="8" />
        <m_bUseHistory>True</m_bUseHistory>
        <m_bUseEmpty>False</m_bUseEmpty>
        <m_bEnabled>True</m_bEnabled>
        <m_lImageIndex>2</m_lImageIndex>
        <m_bOnChangeEvent>True</m_bOnChangeEvent>
        <m_lType>0</m_lType>
        <m_bDeactivate>False</m_bDeactivate>
        <m_bDeadBand>False</m_bDeadBand>
        <m_fDeadBandMin>0</m_fDeadBandMin>
        <m_fDeadBandMax>0</m_fDeadBandMax>
        <m_bMinMax>False</m_bMinMax>
        <m_fMin>0</m_fMin>
        <m_fMax>0</m_fMax>
        <m_bChatEnabled>False</m_bChatEnabled>
        <m_lChatMax>0</m_lChatMax>
        <m_strDefaultValue VT="8" />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem VT="8" />
        <m_str3rdItem VT="8" />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_TIME</m_strItemName>
        <m_strCtrlName VT="8">【SK】TCPIP</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】TCPIP\LogData\T_TIME</FullName>
        <LinkItem VT="8" />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading />
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <m_bSubItem />
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
      </clsCaoSQLItem>
      <Text VT="8">T_TIME</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_NAME">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】TCPIP\LogData\T_NAME</Key>
      <Previous>T_TIME</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8" />
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName VT="8" />
        <m_strSysObjOption VT="8" />
        <m_bDescription>True</m_bDescription>
        <m_strDescription VT="8" />
        <m_bUseHistory>True</m_bUseHistory>
        <m_bUseEmpty>False</m_bUseEmpty>
        <m_bEnabled>True</m_bEnabled>
        <m_lImageIndex>2</m_lImageIndex>
        <m_bOnChangeEvent>True</m_bOnChangeEvent>
        <m_lType>0</m_lType>
        <m_bDeactivate>False</m_bDeactivate>
        <m_bDeadBand>False</m_bDeadBand>
        <m_fDeadBandMin>0</m_fDeadBandMin>
        <m_fDeadBandMax>0</m_fDeadBandMax>
        <m_bMinMax>False</m_bMinMax>
        <m_fMin>0</m_fMin>
        <m_fMax>0</m_fMax>
        <m_bChatEnabled>False</m_bChatEnabled>
        <m_lChatMax>0</m_lChatMax>
        <m_strDefaultValue VT="8" />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem VT="8" />
        <m_str3rdItem VT="8" />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_NAME</m_strItemName>
        <m_strCtrlName VT="8">【SK】TCPIP</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】TCPIP\LogData\T_NAME</FullName>
        <LinkItem VT="8" />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
      </clsCaoSQLItem>
      <Text VT="8">T_NAME</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_LOGDATA">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】TCPIP\LogData\T_LOGDATA</Key>
      <Previous>T_NAME</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">T_DATA</m_strVarName>
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName VT="8" />
        <m_strSysObjOption VT="8" />
        <m_bDescription>True</m_bDescription>
        <m_strDescription VT="8" />
        <m_bUseHistory>True</m_bUseHistory>
        <m_bUseEmpty>False</m_bUseEmpty>
        <m_bEnabled>True</m_bEnabled>
        <m_lImageIndex>2</m_lImageIndex>
        <m_bOnChangeEvent>True</m_bOnChangeEvent>
        <m_lType>0</m_lType>
        <m_bDeactivate>False</m_bDeactivate>
        <m_bDeadBand>False</m_bDeadBand>
        <m_fDeadBandMin>0</m_fDeadBandMin>
        <m_fDeadBandMax>0</m_fDeadBandMax>
        <m_bMinMax>False</m_bMinMax>
        <m_fMin>0</m_fMin>
        <m_fMax>0</m_fMax>
        <m_bChatEnabled>False</m_bChatEnabled>
        <m_lChatMax>0</m_lChatMax>
        <m_strDefaultValue VT="8" />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem VT="8" />
        <m_str3rdItem VT="8" />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_LOGDATA</m_strItemName>
        <m_strCtrlName VT="8">【SK】TCPIP</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】TCPIP\LogData\T_LOGDATA</FullName>
        <LinkItem VT="8" />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading />
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <m_bSubItem />
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
      </clsCaoSQLItem>
      <Text VT="8">T_LOGDATA</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
</INode>