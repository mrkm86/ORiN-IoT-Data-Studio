<?xml version="1.0" encoding="utf-8"?>
<INode xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Object="True" Type="clsCaoSQLController" Name="【SK】RS-232C">
  <Expanded>False</Expanded>
  <Key VT="8">【SK】RS-232C</Key>
  <Selected>False</Selected>
  <clsCaoSQLController Object="True" Property="Tag">
    <m_strProvider VT="8">CaoProv.DNWA.STREAM</m_strProvider>
    <m_strMachine VT="8" />
    <m_strCtrlName VT="8">RS-232C</m_strCtrlName>
    <m_strParam VT="8">Conn=com:3:9600,Sync=False</m_strParam>
    <m_lSamplingRate>300</m_lSamplingRate>
    <m_bDistribute>False</m_bDistribute>
    <m_bDescription>True</m_bDescription>
    <m_strDescription VT="8" />
    <m_bEnabled>False</m_bEnabled>
    <m_lImageIndex>1</m_lImageIndex>
    <m_bStartup>True</m_bStartup>
    <m_bUseHistory>True</m_bUseHistory>
    <m_lPriority>4</m_lPriority>
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
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】コントローラ名取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_NAME").Value = "RS-232C"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">O3CGIEBWW1T61Z22SC9SBZCGT2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>3</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">3ZUAQR9PCK6E299VOPIGNA8P42</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>4</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理開始</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理開始"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">J0JO15737STU3KKMH6X462Z6E2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>5</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">IUOIXNO34AUV297PW4VWXCOJ62</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>6</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>8</m_lAction>
          <m_lCallback />
          <m_strPutItem VT="8">[value]T_DATA</m_strPutItem>
          <m_strPutValue VT="8">Value</m_strPutValue>
          <Description VT="8">【Action】RS-232Cデータ受信</Description>
          <m_strScript />
          <m_bNotSafeMode />
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">JSGP2PAF4PZN183SQ2AIP1BKO2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>7</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">9FIWU9EMHTFB024XZ953RSJW62</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>8</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutItem VT="8">[LogData]T_LOGDATA</m_strPutItem>
          <m_strPutValue VT="8">[value]T_DATA</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】DATA - RS-232Cデータ取得</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">GXXMARWMS4RR2BOJM65FSWRZY1</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>9</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">8UWS7MSKU0VW236VRFP4IE8IS2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>10</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">1DN03U91RT332XY2RE8L321Z22</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>11</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理終了</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理終了"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">ONNY8VBGJT8C0EPIU1QMFD58K2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>12</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">2NPM4FQJXUCZ0ULU8Z6N4UH6B2</m_strId>
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
    <RSQLCtrlName VT="8">【SK】RS-232C</RSQLCtrlName>
    <m_bEventBinding>True</m_bEventBinding>
    <m_bOutputActionLog>False</m_bOutputActionLog>
    <IsRemoteController>false</IsRemoteController>
    <m_lRecWaitTime>5</m_lRecWaitTime>
    <m_lRecType>0</m_lRecType>
    <IsSystemController>false</IsSystemController>
    <IsVirtualController>false</IsVirtualController>
  </clsCaoSQLController>
  <Text VT="8">【SK】RS-232C</Text>
  <BackColor>2147483653</BackColor>
  <Checked>False</Checked>
  <ForeColor>2147483656</ForeColor>
  <INode Object="True" Type="clsCaoSQLGroup" Name="value">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】RS-232C\value</Key>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">value</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_DATA">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】RS-232C\value\T_DATA</Key>
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
        <m_strItemName VT="8">[value]T_DATA</m_strItemName>
        <m_strCtrlName VT="8">【SK】RS-232C</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】RS-232C\value\T_DATA</FullName>
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
      <Text VT="8">T_DATA</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
  <INode Object="True" Type="clsCaoSQLGroup" Name="LogData">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】RS-232C\LogData</Key>
    <Previous>value</Previous>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">LogData</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="ArrayLogData">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】RS-232C\LogData\ArrayLogData</Key>
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
        <m_strCtrlName VT="8">【SK】RS-232C</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】RS-232C\LogData\ArrayLogData</FullName>
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
      <Key VT="8">【SK】RS-232C\LogData\T_TIME</Key>
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
        <m_strCtrlName VT="8">【SK】RS-232C</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】RS-232C\LogData\T_TIME</FullName>
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
      <Key VT="8">【SK】RS-232C\LogData\T_NAME</Key>
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
        <m_strCtrlName VT="8">【SK】RS-232C</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】RS-232C\LogData\T_NAME</FullName>
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
      <Key VT="8">【SK】RS-232C\LogData\T_LOGDATA</Key>
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
        <m_strCtrlName VT="8">【SK】RS-232C</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】RS-232C\LogData\T_LOGDATA</FullName>
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