<?xml version="1.0" encoding="utf-8"?>
<INode xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Object="True" Type="clsCaoSQLController" Name="【SK】Timer_http_to_PATLITE">
  <Expanded>False</Expanded>
  <Key VT="8">【SK】Timer_http_to_PATLITE</Key>
  <Selected>False</Selected>
  <clsCaoSQLController Object="True" Property="Tag">
    <m_strProvider VT="8" PrevValue="CaoProv.DENSO.Timer" />
    <m_strMachine VT="8" />
    <m_strCtrlName VT="8">Timer_http_to_PATLITE</m_strCtrlName>
    <m_strParam VT="8" />
    <m_lSamplingRate>5000</m_lSamplingRate>
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
        <m_lCondition>13</m_lCondition>
        <m_strThreshold />
        <m_bPrevValue>0</m_bPrevValue>
        <m_lConjunction>0</m_lConjunction>
        <Description VT="8">timer</Description>
        <m_lId>1</m_lId>
        <Action>
          <m_lId>2</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】コントローラ名取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_NAME").Value = "Timer_http_to_PATLITE"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">OIENE4EY1EK209E84J94OETTI2</m_strId>
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
          <m_strId VT="8">CX5HBYFT3XPO1YCBGJSU5END22</m_strId>
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
          <m_strId VT="8">NSS6T173ACXO1EM9ZYXHNVVHN2</m_strId>
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
          <m_strId VT="8">ENCP8CA8U0PO1HHADSXRIE8KA2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>6</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>1</m_lCallback>
          <Description VT="8">【Action】http_get_device_status</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">IQT7DAD7BKAH28ZM2EC62YU4L2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>HTTPRequestPlugin.HTTPRequest</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】Timer_http_to_PATLITE</Value>
            </Data>
            <Data>
              <Key>Url</Key>
              <Value>https://XXXXXXXX?T_DEVICE_ID=LINE001</Value>
            </Data>
            <Data>
              <Key>Method</Key>
              <Value>GET</Value>
            </Data>
            <Data>
              <Key>Body</Key>
              <Value />
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
              <Value>[value]T_JSON_RECV</Value>
            </Data>
            <Data>
              <Key>Timeout</Key>
              <Value>100000</Value>
            </Data>
            <Data>
              <Key>ReturnDataType</Key>
              <Value>String</Value>
            </Data>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>HTTPRequestAction.HTTPRequest</Value>
            </Data>
            <Data>
              <Key>Header</Key>
              <Data>
                <Key>Name</Key>
                <Value>Content-Type</Value>
              </Data>
              <Data>
                <Key>Value</Key>
                <Value>application/json</Value>
              </Data>
            </Data>
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>7</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>2</m_lCallback>
          <Description VT="8">【Action】split_json_to_item</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">YJ88REIXAOMN1JH4PSGL8XWUW2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>InputJsonPlugin.PluginMain</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】Timer_http_to_PATLITE</Value>
            </Data>
            <Data>
              <Key>JSON_ITEM</Key>
              <Value>[value]T_JSON_RECV</Value>
            </Data>
            <Data>
              <Key>JSON</Key>
              <Value>{
  "items": [
    {
      "t_active": "$[value]T_ACTIVE"
    }
  ]
}</Value>
            </Data>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>InputJsonAction.InputJson</Value>
            </Data>
            <Data>
              <Key>TARGET_ITEM</Key>
              <Data>
                <Key>JSON_PATH</Key>
                <Value>items[0].t_active</Value>
              </Data>
              <Data>
                <Key>PATH</Key>
                <Value>$[value]T_ACTIVE</Value>
              </Data>
              <Data>
                <Key>TYPE</Key>
                <Value>BSTR</Value>
              </Data>
            </Data>
          </PluginConfig>
        </Action>
        <Evaluation>
          <m_bEnabled>True</m_bEnabled>
          <m_strName VT="8">[value]T_ACTIVE</m_strName>
          <m_lCondition>0</m_lCondition>
          <m_strThreshold VT="8">1</m_strThreshold>
          <m_bPrevValue>0</m_bPrevValue>
          <m_lConjunction>0</m_lConjunction>
          <Description VT="8">稼働/非稼働の判定</Description>
          <m_lId>8</m_lId>
          <Action>
            <m_lId>9</m_lId>
            <m_bEnabled>False</m_bEnabled>
            <m_lAction>6</m_lAction>
            <m_strPutController VT="8">【SK】PATLITE</m_strPutController>
            <m_strPutItem VT="8">@RED</m_strPutItem>
            <m_strPutValue VT="8">0</m_strPutValue>
            <m_lPutType>8</m_lPutType>
            <Description VT="8">【Action】PATLITEのLED:赤を消灯</Description>
            <clsCaoSQLUserDefineBDInfo />
            <m_strId VT="8">BF201KE5FBKY0JBF8T60QYELB2</m_strId>
            <ExecuteParam />
            <CalculationList />
            <PluginConfig />
          </Action>
          <Action>
            <m_lId>10</m_lId>
            <m_bEnabled>False</m_bEnabled>
            <m_lAction>6</m_lAction>
            <m_strPutController VT="8">【SK】PATLITE</m_strPutController>
            <m_strPutItem VT="8">@GREEN</m_strPutItem>
            <m_strPutValue VT="8">1</m_strPutValue>
            <m_lPutType>8</m_lPutType>
            <Description VT="8">【Action】PATLITEのLED:緑を点灯</Description>
            <clsCaoSQLUserDefineBDInfo />
            <m_strId VT="8">JKY5UVUIYF063W6PPPG3VNQ5E2</m_strId>
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
            <m_strId VT="8">TJ8C9MHU3P1Z0LIQNCJPTU7CM2</m_strId>
            <ExecuteParam />
            <CalculationList />
            <PluginConfig />
          </Action>
          <Action>
            <m_lId>12</m_lId>
            <m_bEnabled>True</m_bEnabled>
            <m_lAction>7</m_lAction>
            <Description VT="8">【LogData】DATA - T_ACTIVE==1</Description>
            <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "LED:赤-&gt;消灯 緑:点灯"
End Sub</m_strScript>
            <m_bNotSafeMode>0</m_bNotSafeMode>
            <clsCaoSQLUserDefineBDInfo />
            <m_strId VT="8">FDAJNU4GDH601RA4W2KMFOOS22</m_strId>
            <ExecuteParam />
            <CalculationList />
            <PluginConfig />
          </Action>
          <Action>
            <m_lId>13</m_lId>
            <m_bEnabled>True</m_bEnabled>
            <m_lAction>6</m_lAction>
            <m_strPutController VT="8">【SK】LogData</m_strPutController>
            <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
            <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
            <m_lPutType>29</m_lPutType>
            <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
            <clsCaoSQLUserDefineBDInfo />
            <m_strId VT="8">ARBRE1CR3U8J2ICX3DU6FR0XW2</m_strId>
            <ExecuteParam />
            <CalculationList />
            <PluginConfig />
          </Action>
          <Else>
            <Action>
              <m_lId>14</m_lId>
              <m_bEnabled>False</m_bEnabled>
              <m_lAction>6</m_lAction>
              <m_strPutController VT="8">【SK】PATLITE</m_strPutController>
              <m_strPutItem VT="8">@RED</m_strPutItem>
              <m_strPutValue VT="8">1</m_strPutValue>
              <m_lPutType>8</m_lPutType>
              <Description VT="8">【Action】PATLITEのLED:赤を点灯</Description>
              <clsCaoSQLUserDefineBDInfo />
              <m_strId VT="8">0X2IXXT4X1AO1GPEFLHMRSF8C2</m_strId>
              <ExecuteParam />
              <CalculationList />
              <PluginConfig />
            </Action>
            <Action>
              <m_lId>15</m_lId>
              <m_bEnabled>False</m_bEnabled>
              <m_lAction>6</m_lAction>
              <m_strPutController VT="8">【SK】PATLITE</m_strPutController>
              <m_strPutItem VT="8">@GREEN</m_strPutItem>
              <m_strPutValue VT="8">0</m_strPutValue>
              <m_lPutType>8</m_lPutType>
              <Description VT="8">【Action】PATLITEのLED:緑を消灯</Description>
              <clsCaoSQLUserDefineBDInfo />
              <m_strId VT="8">EM6BKDVJN0QA1K59TWNFTD82J2</m_strId>
              <ExecuteParam />
              <CalculationList />
              <PluginConfig />
            </Action>
            <Action>
              <m_lId>16</m_lId>
              <m_bEnabled>True</m_bEnabled>
              <m_lAction>7</m_lAction>
              <Description VT="8">【LogData】START - 処理日付取得</Description>
              <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
              <m_bNotSafeMode>0</m_bNotSafeMode>
              <clsCaoSQLUserDefineBDInfo />
              <m_strId VT="8">14B8W1UA6MXE1TO1SZCQFPHOQ2</m_strId>
              <ExecuteParam />
              <CalculationList />
              <PluginConfig />
            </Action>
            <Action>
              <m_lId>17</m_lId>
              <m_bEnabled>True</m_bEnabled>
              <m_lAction>7</m_lAction>
              <Description VT="8">【LogData】DATA - T_ACTIVE==0</Description>
              <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "LED:赤-&gt;点灯 緑:消灯"
End Sub</m_strScript>
              <m_bNotSafeMode>0</m_bNotSafeMode>
              <clsCaoSQLUserDefineBDInfo />
              <m_strId VT="8">TOXVZ2QMTJ4P28M3HZ10BWE012</m_strId>
              <ExecuteParam />
              <CalculationList />
              <PluginConfig />
            </Action>
            <Action>
              <m_lId>18</m_lId>
              <m_bEnabled>True</m_bEnabled>
              <m_lAction>6</m_lAction>
              <m_strPutController VT="8">【SK】LogData</m_strPutController>
              <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
              <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
              <m_lPutType>29</m_lPutType>
              <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
              <clsCaoSQLUserDefineBDInfo />
              <m_strId VT="8">MKYTO38PB2L91ORGHY6L03L7O2</m_strId>
              <ExecuteParam />
              <CalculationList />
              <PluginConfig />
            </Action>
          </Else>
        </Evaluation>
        <Action>
          <m_lId>19</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">4RFUEL8E33QQ3YWRTFPVEE6MM2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>20</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理終了</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理終了"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">X2IB9ZD3PXDX1ILXM56G8U9JV2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>21</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">AUOAXL6599MI19H69AWOII5712</m_strId>
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
    <m_strScript VT="8" />
    <m_bNotSafeMode>False</m_bNotSafeMode>
    <ClassAttribute>1</ClassAttribute>
    <RSQLCtrlName VT="8">【SK】Timer_http_to_PATLITE</RSQLCtrlName>
    <m_bEventBinding>False</m_bEventBinding>
    <m_bOutputActionLog>False</m_bOutputActionLog>
    <IsRemoteController>false</IsRemoteController>
    <m_lRecWaitTime>5</m_lRecWaitTime>
    <m_lRecType>0</m_lRecType>
    <IsSystemController>false</IsSystemController>
    <IsVirtualController>false</IsVirtualController>
  </clsCaoSQLController>
  <Text VT="8">【SK】Timer_http_to_PATLITE</Text>
  <BackColor>2147483653</BackColor>
  <Checked>False</Checked>
  <ForeColor>2147483656</ForeColor>
  <INode Object="True" Type="clsCaoSQLGroup" Name="value">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】Timer_http_to_PATLITE\value</Key>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">value</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_JSON_RECV">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】Timer_http_to_PATLITE\value\T_JSON_RECV</Key>
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
        <m_strItemName VT="8">[value]T_JSON_RECV</m_strItemName>
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\value\T_JSON_RECV</FullName>
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
      <Text VT="8">T_JSON_RECV</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_ACTIVE">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】Timer_http_to_PATLITE\value\T_ACTIVE</Key>
      <Previous>T_JSON_RECV</Previous>
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
        <m_strItemName VT="8">[value]T_ACTIVE</m_strItemName>
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\value\T_ACTIVE</FullName>
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
      <Text VT="8">T_ACTIVE</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="T_RESPONSE">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】Timer_http_to_PATLITE\value\T_RESPONSE</Key>
      <Previous>T_ACTIVE</Previous>
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
        <m_strItemName VT="8">[value]T_RESPONSE</m_strItemName>
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\value\T_RESPONSE</FullName>
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
      <Text VT="8">T_RESPONSE</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
  <INode Object="True" Type="clsCaoSQLGroup" Name="LogData">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】Timer_http_to_PATLITE\LogData</Key>
    <Previous>value</Previous>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">LogData</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="ArrayLogData">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】Timer_http_to_PATLITE\LogData\ArrayLogData</Key>
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
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\LogData\ArrayLogData</FullName>
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
      <Key VT="8">【SK】Timer_http_to_PATLITE\LogData\T_TIME</Key>
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
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\LogData\T_TIME</FullName>
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
      <Key VT="8">【SK】Timer_http_to_PATLITE\LogData\T_NAME</Key>
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
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\LogData\T_NAME</FullName>
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
      <Key VT="8">【SK】Timer_http_to_PATLITE\LogData\T_LOGDATA</Key>
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
        <m_strCtrlName VT="8">【SK】Timer_http_to_PATLITE</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】Timer_http_to_PATLITE\LogData\T_LOGDATA</FullName>
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