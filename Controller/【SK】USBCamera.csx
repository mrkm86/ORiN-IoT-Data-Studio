<?xml version="1.0" encoding="utf-8"?>
<INode xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" Object="True" Type="clsCaoSQLController" Name="【SK】USBCamera">
  <Expanded>False</Expanded>
  <Key VT="8">【SK】USBCamera</Key>
  <Selected>False</Selected>
  <clsCaoSQLController Object="True" Property="Tag">
    <m_strProvider VT="8">CaoProv.DirectShow</m_strProvider>
    <m_strMachine VT="8" />
    <m_strCtrlName VT="8">USBCamera</m_strCtrlName>
    <m_strParam VT="8">FrameRate=15:15:0:0:0:0:0:0:0:0 </m_strParam>
    <m_lSamplingRate>10000</m_lSamplingRate>
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
        <Description VT="8">カメラ画像を取得する</Description>
        <m_lId>1</m_lId>
        <Action>
          <m_lId>2</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】コントローラ名取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_NAME").Value = "USBCamera"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">CYRJ7K3NF7S51LUSRYVB2DCBB2</m_strId>
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
          <m_strId VT="8">XV1B5A3FY1Y90JZPDGEVI3WL82</m_strId>
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
          <m_strId VT="8">AOEKFG7ELRMA24KMQFU96DIN02</m_strId>
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
          <m_strId VT="8">4W0RISGJEXQK1USLOC2S6M4PN2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>6</m_lId>
          <m_bEnabled>False</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>1</m_lCallback>
          <Description VT="8">【Action】CAMERA1画像保存</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">NWV7XUCFH0B50VR7K3O0KQ02P2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>OutputFilePlugin.OutputFile</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>OutputFileAction.OutputFile</Value>
            </Data>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】USBCamera</Value>
            </Data>
            <Data>
              <Key>Folder</Key>
              <Value>C:\Users\murak\Desktop</Value>
            </Data>
            <Data>
              <Key>FileName</Key>
              <Value>camera1.jpg</Value>
            </Data>
            <Data>
              <Key>Item</Key>
              <Value>@CAMERA_1</Value>
            </Data>
            <Data>
              <Key>WriteMode</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>_Async</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>CloseEachWrite</Key>
              <Value>0</Value>
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
              <Key>OutputType</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>TerminalSymbol</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>ByteOrder</Key>
              <Value>0</Value>
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
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>7</m_lId>
          <m_bEnabled>False</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>2</m_lCallback>
          <Description VT="8">【Action】CAMERA2画像保存</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">92ZFHB5FXQUE2V8KVDC41BHJF2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>OutputFilePlugin.OutputFile</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>_TriggerActionFullName</Key>
              <Value>OutputFileAction.OutputFile</Value>
            </Data>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】USBCamera</Value>
            </Data>
            <Data>
              <Key>Folder</Key>
              <Value>C:\Users\murak\Desktop</Value>
            </Data>
            <Data>
              <Key>FileName</Key>
              <Value>camera2.jpg</Value>
            </Data>
            <Data>
              <Key>Item</Key>
              <Value>@CAMERA_2</Value>
            </Data>
            <Data>
              <Key>WriteMode</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>_Async</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>CloseEachWrite</Key>
              <Value>0</Value>
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
              <Key>OutputType</Key>
              <Value>1</Value>
            </Data>
            <Data>
              <Key>TerminalSymbol</Key>
              <Value>0</Value>
            </Data>
            <Data>
              <Key>ByteOrder</Key>
              <Value>0</Value>
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
          </PluginConfig>
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
          <m_strId VT="8">CC1EHEXA449P25GKE7ONE474Z1</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>9</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 画像保存</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "画像を保存しました"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">K07N5SPAXKGS3N0O5N7GF8DJR2</m_strId>
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
          <m_strId VT="8">13IVYJ853Q9F11PW8DP6LL34M2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>11</m_lId>
          <m_bEnabled>False</m_bEnabled>
          <m_lAction>4</m_lAction>
          <m_strExeFile VT="8">c:\ORiN2\CAO\Tools\CaoScript\Bin\CaoScript.exe</m_strExeFile>
          <m_strExeParams VT="8">C:\Users\murak\Desktop\desktop\bmp2base64.vbs Main start</m_strExeParams>
          <Description VT="8">【Action】CAMERA1_base64処理開始</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">LZS2P3XC1PP80OPVJ8V914NTS2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>12</m_lId>
          <m_bEnabled>False</m_bEnabled>
          <m_lAction>4</m_lAction>
          <m_strExeFile VT="8">C:\Users\murak\Desktop\desktop\killCaoScprit.bat</m_strExeFile>
          <m_strExeParams VT="8">/F</m_strExeParams>
          <Description VT="8">【Action】CAMERA1_base64処理終了</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">VHG31QPTIM4K3SS394AVFYOQ72</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>13</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>3</m_lCallback>
          <Description VT="8">【Action】CAMERA1画像http連携</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">5QE7NONJMVAO3KCHRYFGU6KOV2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>HTTPRequestPlugin.HTTPRequest</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】USBCamera</Value>
            </Data>
            <Data>
              <Key>Url</Key>
              <Value>https://XXX-XXXXX?T_DEVICE_ID=LINE001</Value>
            </Data>
            <Data>
              <Key>Method</Key>
              <Value>POST</Value>
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
              <Key>IsBinaryBodyType</Key>
              <Value>True</Value>
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
            <Data>
              <Key>ContentArgs</Key>
              <Data>
                <Key>Controller</Key>
                <Value />
              </Data>
              <Data>
                <Key>Item</Key>
                <Value>[value]T_BASE64_1</Value>
              </Data>
            </Data>
          </PluginConfig>
        </Action>
        <Action>
          <m_lId>14</m_lId>
          <m_bEnabled>False</m_bEnabled>
          <m_lAction>5</m_lAction>
          <m_lCallback>4</m_lCallback>
          <Description VT="8">【Action】CAMERA2画像http連携</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">5L54EDUAYONE0ER2X3F8YXWLQ2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginFullName>HTTPRequestPlugin.HTTPRequest</PluginFullName>
          <PluginConfig>
            <Data>
              <Key>__Controller</Key>
              <Value>【SK】USBCamera</Value>
            </Data>
            <Data>
              <Key>Url</Key>
              <Value>https://XXX-XXXXX?T_DEVICE_ID=LINE002</Value>
            </Data>
            <Data>
              <Key>Method</Key>
              <Value>POST</Value>
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
              <Key>Header</Key>
              <Data>
                <Key>Name</Key>
                <Value>Content-Type</Value>
              </Data>
              <Data>
                <Key>Value</Key>
                <Value>image/jpeg</Value>
              </Data>
            </Data>
            <Data>
              <Key>IsBinaryBodyType</Key>
              <Value>True</Value>
            </Data>
            <Data>
              <Key>BodyBinaryItem</Key>
              <Data>
                <Key>Controller</Key>
                <Value />
              </Data>
              <Data>
                <Key>Item</Key>
                <Value>[value]@CAMERA_2</Value>
              </Data>
            </Data>
          </PluginConfig>
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
          <m_strId VT="8">S9QX0WVNG7YZ2D1LV39YBZY6V2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>16</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 画像http連携</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "画像http連携"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">XHGZCIZV6QLO2WXDW42DW4PWZ1</m_strId>
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
          <m_strId VT="8">9E057RTZXQOM0THL32JH55GXD2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>18</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】START - 処理日付取得</Description>
          <m_strScript VT="8">Sub Main()
	MyCtrl("[LogData]T_TIME").Value = Now()
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">APKQN8NFCJU3359U6NA7KM2C62</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>19</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>7</m_lAction>
          <Description VT="8">【LogData】DATA - 処理終了</Description>
          <m_strScript VT="8">'実際にはこのT_DATAに値が入ってこないので、ログ用に値を入れておく
Sub Main()
	MyCtrl("[LogData]T_LOGDATA").Value = "処理終了"
End Sub</m_strScript>
          <m_bNotSafeMode>0</m_bNotSafeMode>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">HHTGIOUTZ2Y91G3804SECQDEG2</m_strId>
          <ExecuteParam />
          <CalculationList />
          <PluginConfig />
        </Action>
        <Action>
          <m_lId>20</m_lId>
          <m_bEnabled>True</m_bEnabled>
          <m_lAction>6</m_lAction>
          <m_strPutController VT="8">【SK】LogData</m_strPutController>
          <m_strPutItem VT="8">[value]@QPush</m_strPutItem>
          <m_strPutValue VT="8">[LogData]ArrayLogData</m_strPutValue>
          <m_lPutType>29</m_lPutType>
          <Description VT="8">【LogData】END - ログデータスレッドに登録</Description>
          <clsCaoSQLUserDefineBDInfo />
          <m_strId VT="8">UDPBVVYD249R3PW842AN03BZZ1</m_strId>
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
    <RSQLCtrlName VT="8">【SK】USBCamera</RSQLCtrlName>
    <m_bEventBinding>False</m_bEventBinding>
    <m_bOutputActionLog>False</m_bOutputActionLog>
    <IsRemoteController>false</IsRemoteController>
    <m_lRecWaitTime>5</m_lRecWaitTime>
    <m_lRecType>0</m_lRecType>
    <IsSystemController>false</IsSystemController>
    <IsVirtualController>false</IsVirtualController>
  </clsCaoSQLController>
  <Text VT="8">【SK】USBCamera</Text>
  <BackColor>2147483653</BackColor>
  <Checked>False</Checked>
  <ForeColor>2147483656</ForeColor>
  <INode Object="True" Type="clsCaoSQLGroup" Name="value">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】USBCamera\value</Key>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">value</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="@CAMERA_1">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera\value\@CAMERA_1</Key>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">@VALUE</m_strVarName>
        <m_lSystemType VT="8">4</m_lSystemType>
        <m_strSysObjName VT="8">CAMERA_1</m_strSysObjName>
        <m_strSysObjOption VT="8">ID=1</m_strSysObjOption>
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
        <m_bVariableEnabled>True</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" Meta="ProgId=CaoProv.DirectShow,Index=-1" />
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
        <m_strItemName VT="8">[value]@CAMERA_1</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\value\@CAMERA_1</FullName>
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
      <Text VT="8">@CAMERA_1</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
    <INode Object="True" Type="clsCaoSQLItem" Name="@CAMERA_2">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera\value\@CAMERA_2</Key>
      <Previous>@CAMERA_1</Previous>
      <Selected>False</Selected>
      <clsCaoSQLItem Object="True" Property="Tag">
        <m_strVarName VT="8">@VALUE</m_strVarName>
        <m_lSystemType VT="8">4</m_lSystemType>
        <m_strSysObjName VT="8">CAMERA_2</m_strSysObjName>
        <m_strSysObjOption VT="8">ID=2</m_strSysObjOption>
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
        <m_bVariableEnabled>True</m_bVariableEnabled>
        <m_bInitialize>False</m_bInitialize>
        <m_strInitData VT="8" />
        <m_lInitDataType>3</m_lInitDataType>
        <m_strOption VT="8" Meta="ProgId=CaoProv.DirectShow,Index=-1" />
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
        <m_strItemName VT="8">[value]@CAMERA_2</m_strItemName>
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\value\@CAMERA_2</FullName>
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
      <Text VT="8">@CAMERA_2</Text>
      <BackColor>2147483653</BackColor>
      <Checked>False</Checked>
      <ForeColor>2147483656</ForeColor>
    </INode>
  </INode>
  <INode Object="True" Type="clsCaoSQLGroup" Name="LogData">
    <Expanded>False</Expanded>
    <Key VT="8">【SK】USBCamera\LogData</Key>
    <Previous>value</Previous>
    <Selected>False</Selected>
    <clsCaoSQLGroup Object="True" Property="Tag" />
    <Text VT="8">LogData</Text>
    <BackColor>2147483653</BackColor>
    <Checked>False</Checked>
    <ForeColor>2147483656</ForeColor>
    <INode Object="True" Type="clsCaoSQLItem" Name="ArrayLogData">
      <Expanded>False</Expanded>
      <Key VT="8">【SK】USBCamera\LogData\ArrayLogData</Key>
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
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\LogData\ArrayLogData</FullName>
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
      <Key VT="8">【SK】USBCamera\LogData\T_TIME</Key>
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
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\LogData\T_TIME</FullName>
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
      <Key VT="8">【SK】USBCamera\LogData\T_NAME</Key>
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
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\LogData\T_NAME</FullName>
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
      <Key VT="8">【SK】USBCamera\LogData\T_LOGDATA</Key>
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
        <m_strCtrlName VT="8">【SK】USBCamera</m_strCtrlName>
        <ClassAttribute>2</ClassAttribute>
        <FullName VT="8">【SK】USBCamera\LogData\T_LOGDATA</FullName>
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