<?xml version="1.0" encoding="utf-8"?>
<INode xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Object="True" Type="clsCaoSQLController" Name="【SK】USBCamera_to_AzureBLOB">
  <Expanded>True</Expanded>
  <Key VT="8">【SK】USBCamera_to_AzureBLOB</Key>
  <Selected>True</Selected>
  <TargetVersion>V_01_07_0000_0000</TargetVersion>
  <clsCaoSQLController Object="True" Property="Tag">
    <m_strProvider>CaoProv.DirectShow</m_strProvider>
    <m_strMachine />
    <m_strCtrlName VT="8">USBCamera_1</m_strCtrlName>
    <m_strParam VT="8">CameraDisable = 0, FormatType = 0:0:0:0:0:0:0:0:0:0, FrameRate = 0:0:0:0:0:0:0:0:0:0, ImageType = 2, JpegQuality = 100</m_strParam>
    <m_lSamplingRate>10000</m_lSamplingRate>
    <m_bSlowSamplingEnable>False</m_bSlowSamplingEnable>
    <m_lSlowSamplingRate>3000</m_lSlowSamplingRate>
    <m_bDistribute>False</m_bDistribute>
    <m_bDescription>True</m_bDescription>
    <m_strDescription />
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
    <m_lWDTTime>300</m_lWDTTime>
    <m_lWDTAction>0</m_lWDTAction>
    <m_bUseTrigger>False</m_bUseTrigger>
    <m_bTriggerDisable>False</m_bTriggerDisable>
    <m_bCalcDisable>False</m_bCalcDisable>
    <Collection Object="True" Property="m_mapTrigger">
      <clsCaoSQLTriggerItem Object="True" Index="1">
        <m_strName />
        <clsCaoSQLTriggerInfo Object="True" Index="1">
          <m_lAction>0</m_lAction>
          <m_strExeFile />
          <m_strExeParams />
          <m_lCondition>-1</m_lCondition>
          <m_strThreshold />
        </clsCaoSQLTriggerInfo>
        <clsCaoSQLTriggerInfo Object="True" Index="2">
          <m_lAction>0</m_lAction>
          <m_strExeFile />
          <m_strExeParams />
          <m_lCondition>-1</m_lCondition>
          <m_strThreshold />
        </clsCaoSQLTriggerInfo>
        <NewEnum />
        <Count>2</Count>
      </clsCaoSQLTriggerItem>
    </Collection>
    <TriggerEx>
      <m_bEnabled>True</m_bEnabled>
      <m_lId>0</m_lId>
      <Action>
        <m_lId>1</m_lId>
        <m_bEnabled>True</m_bEnabled>
        <m_lAction>7</m_lAction>
        <Description>imageのState取得</Description>
        <m_strScript>Sub Main()
	MyCtrl.Item("[value]T_STATE").Value = MyCtrl.Item("[value]@CAMERA_1").State
End Sub</m_strScript>
        <m_bNotSafeMode>0</m_bNotSafeMode>
        <m_strId>TCO431SJJ79E2AEI5VUPAQZA52</m_strId>
      </Action>
      <Evaluation>
        <m_bEnabled>True</m_bEnabled>
        <m_strName>[value]T_STATE</m_strName>
        <m_lCondition>0</m_lCondition>
        <m_strThreshold>0</m_strThreshold>
        <m_bPrevValue>0</m_bPrevValue>
        <m_lConjunction>0</m_lConjunction>
        <Description>imageが取得できた場合</Description>
        <m_lId>2</m_lId>
        <Miscs />
        <Action>
          <m_lId>3</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】コントローラ名取得</Description>
          <m_strScript>Sub Main()
	MyCtrl("[LogData]T_NAME").Value = "USBCamera"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>DQ59D8YIH1UC0BKFKR7XP11QM2</m_strId>
        </Action>
        <Action>
          <m_lId>4</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】START - 処理日付取得</Description>
          <m_strScript>Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>76B7DQ1Y3TUR05E5ZG8XXF09N2</m_strId>
        </Action>
        <Action>
          <m_lId>5</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】DATA - 処理開始</Description>
          <m_strScript>'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理開始"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>WCRN9O0NDTIT3EWLTJFTK6OLL2</m_strId>
        </Action>
        <Action>
          <m_lId>6</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController>【SK】LogData</m_strPutController>
          <m_strPutItem>[value]@QPush</m_strPutItem>
          <m_strPutValue>[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description>【LogData】END - ログデータスレッドに登録</Description>
          <m_strId>2GCD6KNCZ0ON1AOXDY0SWOPY72</m_strId>
        </Action>
        <Action>
          <m_lId>7</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】START - 処理日付取得</Description>
          <m_strScript>Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>1NTPCSX5B20Y0FNGG8YHYCMVD2</m_strId>
        </Action>
        <Action>
          <m_lId>8</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】DATA - 画像http連携</Description>
          <m_strScript>'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "画像http連携"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>KWJATQ2S5IKU2NQ2FJXKLCAWG2</m_strId>
        </Action>
        <Action>
          <m_lId>9</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController>【SK】LogData</m_strPutController>
          <m_strPutItem>[value]@QPush</m_strPutItem>
          <m_strPutValue>[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description>【LogData】END - ログデータスレッドに登録</Description>
          <m_strId>S1O6XKJOHG0O1YEILRN7TMQEZ1</m_strId>
        </Action>
        <Action>
          <m_lId>10</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>1</m_lCallback>
          <Description>【Action】CAMERA1画像http連携</Description>
          <m_strId>SPUB1XKJFZGR19R7GDTKXU8372</m_strId>
          <PluginFullName>HTTPRequestPlugin.HTTPRequest</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】USBCamera_to_AzureBLOB</Value>
            </Data>
            <Data>
              <Key>Url</Key>
              <Value>https://xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx</Value>
            </Data>
            <Data>
              <Key>Method</Key>
              <Value>PUT</Value>
            </Data>
            <Data>
              <Key>Body</Key>
              <Value>{0}</Value>
            </Data>
            <Data>
              <Key>StatusCodeItem</Key>
              <Value>[value]T_RESPONSE</Value>
            </Data>
            <Data>
              <Key>ReturnHeaders</Key>
              <Value />
            </Data>
            <Data>
              <Key>ReturnDataItem</Key>
              <Value />
            </Data>
            <Data>
              <Key>Timeout</Key>
              <Value>100000</Value>
            </Data>
            <Data>
              <Key>ReturnDataType</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>HTTPRequestAction.HTTPRequest</Value>
            </Data>
            <Data>
              <Key>IsBinaryBodyType</Key>
              <Value>True</Value>
            </Data>
            <Data>
              <Key>Header</Key>
              <Data>
                <Key>Name</Key>
                <Value>Content-Type</Value>
              </Data>
              <Data>
                <Key>Value</Key>
                <Value>image/bmp</Value>
              </Data>
            </Data>
            <Data>
              <Key>Header</Key>
              <Data>
                <Key>Name</Key>
                <Value>x-ms-blob-type</Value>
              </Data>
              <Data>
                <Key>Value</Key>
                <Value>BlockBlob</Value>
              </Data>
            </Data>
            <Data>
              <Key>BodyBinaryItem</Key>
              <Data>
                <Key>Controller</Key>
                <Value />
              </Data>
              <Data>
                <Key>Item</Key>
                <Value>[value]@CAMERA_1</Value>
              </Data>
            </Data>
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>11</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】START - 処理日付取得</Description>
          <m_strScript>Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>951Q21GQG43L07PK5XUIC51EQ2</m_strId>
        </Action>
        <Action>
          <m_lId>12</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description>【LogData】DATA - 処理終了</Description>
          <m_strScript>'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理終了"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <m_strId>17HXBEUY2SF301A70AR8AHAPQ2</m_strId>
        </Action>
        <Action>
          <m_lId>13</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController>【SK】LogData</m_strPutController>
          <m_strPutItem>[value]@QPush</m_strPutItem>
          <m_strPutValue>[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description>【LogData】END - ログデータスレッドに登録</Description>
          <m_strId>EE4S2DFFRXWB16VLK4WM6358E2</m_strId>
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
    <RSQLCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</RSQLCtrlName>
    <m_bEventBinding>False</m_bEventBinding>
    <m_bOutputActionLog>False</m_bOutputActionLog>
    <IsRemoteController>false</IsRemoteController>
    <m_lRecWaitTime>5</m_lRecWaitTime>
    <m_lRecType>0</m_lRecType>
    <IsSystemController>false</IsSystemController>
    <IsVirtualController>false</IsVirtualController>
    <m_AccessibleApplication>7</m_AccessibleApplication>
  </clsCaoSQLController>
  <Text VT="8">【SK】USBCamera_to_AzureBLOB</Text>
  <BackColor>2147483653</BackColor>
  <Checked>False</Checked>
  <ForeColor>2147483656</ForeColor>
  <INode Object="True" Type="clsCaoSQLGroup" Name="value">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】USBCamera_to_AzureBLOB\value</Key>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">value</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="@CAMERA_1">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\value\@CAMERA_1</Key>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName>@VALUE</m_strVarName>
        <m_lSystemType>4</m_lSystemType>
        <m_strSysObjName>CAMERA_1</m_strSysObjName>
        <m_strSysObjOption>ID=1</m_strSysObjOption>
        <m_bDescription>True</m_bDescription>
        <m_strDescription />
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
        <m_strDefaultValue />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>True</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem />
        <m_str3rdItem />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[value]@CAMERA_1</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\value\@CAMERA_1</FullName>
        <LinkItem />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter>\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>7</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">@CAMERA_1</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_STATE">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\value\T_STATE</Key>
      <Previous>@CAMERA_1</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">T_STATE</m_strVarName>
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
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[value]T_STATE</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\value\T_STATE</FullName>
        <LinkItem VT="8" />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter VT="8">\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>0</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">T_STATE</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
  <INode Object="True" Type="clsCaoSQLGroup" Name="LogData">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】USBCamera_to_AzureBLOB\LogData</Key>
    <Previous>value</Previous>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">LogData</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="ArrayLogData">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\LogData\ArrayLogData</Key>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName />
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName />
        <m_strSysObjOption />
        <m_bDescription>True</m_bDescription>
        <m_strDescription />
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
        <m_strDefaultValue />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem />
        <m_str3rdItem />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>True</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]ArrayLogData</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\LogData\ArrayLogData</FullName>
        <LinkItem>[LogData]T_TIME,[LogData]T_NAME,[LogData]T_LOGDATA</LinkItem>
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter>\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>7</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">ArrayLogData</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_TIME">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_TIME</Key>
      <Previous>ArrayLogData</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName>T_TIME</m_strVarName>
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName />
        <m_strSysObjOption />
        <m_bDescription>True</m_bDescription>
        <m_strDescription />
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
        <m_strDefaultValue />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem />
        <m_str3rdItem />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_TIME</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_TIME</FullName>
        <LinkItem />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading />
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter>\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem />
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>7</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">T_TIME</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_NAME">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_NAME</Key>
      <Previous>T_TIME</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName />
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName />
        <m_strSysObjOption />
        <m_bDescription>True</m_bDescription>
        <m_strDescription />
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
        <m_strDefaultValue />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem />
        <m_str3rdItem />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_NAME</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_NAME</FullName>
        <LinkItem />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading>False</m_bDirectReading>
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter>\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem>False</m_bSubItem>
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>7</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">T_NAME</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_LOGDATA">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_LOGDATA</Key>
      <Previous>T_NAME</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName>T_DATA</m_strVarName>
        <m_lSystemType>0</m_lSystemType>
        <m_strSysObjName />
        <m_strSysObjOption />
        <m_bDescription>True</m_bDescription>
        <m_strDescription />
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
        <m_strDefaultValue />
        <m_lAttribute>0</m_lAttribute>
        <m_lForceChange>0</m_lForceChange>
        <m_bVariableEnabled>False</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption />
        <m_lDataType>0</m_lDataType>
        <m_bMaskEnabled>False</m_bMaskEnabled>
        <m_lMask>0</m_lMask>
        <m_bBCD>False</m_bBCD>
        <m_lCalcIndex>0</m_lCalcIndex>
        <m_lCalcIndex2>0</m_lCalcIndex2>
        <m_str2ndItem />
        <m_str3rdItem />
        <m_bChangeType>False</m_bChangeType>
        <m_lRequestType>12</m_lRequestType>
        <m_bChangeTypeW>False</m_bChangeTypeW>
        <m_lRequestTypeW>12</m_lRequestTypeW>
        <m_bCompArrays>True</m_bCompArrays>
        <m_bExtrLink>False</m_bExtrLink>
        <m_lLinkProp>0</m_lLinkProp>
        <m_strItemName VT="8">[LogData]T_LOGDATA</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera_to_AzureBLOB</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera_to_AzureBLOB\LogData\T_LOGDATA</FullName>
        <LinkItem />
        <IsGroupMember>True</IsGroupMember>
        <m_bDirectReading />
        <m_lDirectReadingSuppressedTime />
        <m_bNotRecJudgeItem>False</m_bNotRecJudgeItem>
        <m_bUseFileObjDelimiter>False</m_bUseFileObjDelimiter>
        <m_strFileObjDelimiter>\</m_strFileObjDelimiter>
        <IsRemoteItem>False</IsRemoteItem>
        <m_bSubItem />
        <CalculationList>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
          <Calculation>
            <m_lCalcIndex>0</m_lCalcIndex>
          </Calculation>
        </CalculationList>
        <m_AccessibleApplication>7</m_AccessibleApplication>
      </clsCaoSQLItem>
      <Text VT="8">T_LOGDATA</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
</INode>