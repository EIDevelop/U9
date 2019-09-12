
echo reset IIS
echo iisreset

echo beging copy componet dll to portal and appserver

copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.Deploy.dll  D:\Yonyou\MyTestProject\Portal\ApplicationLib
copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.Deploy.pdb  D:\Yonyou\MyTestProject\Portal\ApplicationLib

copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.dll  D:\Yonyou\MyTestProject\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.pdb  D:\Yonyou\MyTestProject\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.Deploy.dll  D:\Yonyou\MyTestProject\Portal\ApplicationServer\Libs

copy .\Entity\bin\Debug\UFIDA.U9.CC.MyTestBE.Deploy.pdb  D:\Yonyou\MyTestProject\Portal\ApplicationServer\Libs



echo begin run build component Script
echo DIR1: .\..\..\..\UBFV60\U9.VOB.Product.Other\\h_app\MetadataScript\
echo DIR2: .\..\..\..\UBFV60\U9.VOB.Product.Other\\h_app\DBScript\
echo .\..\..\..\UBFV60\U9.VOB.Product.UBF\UBFStudio\Runtime\\..\DBScriptExecutor.exe -connStr "
			packet size=4096;
			user id=sa;
			Connection Timeout=150;
			Max Pool size=1500;
			data source=test;
			persist security info=True;
			initial catalog=STU9DATA;
			password=abc.123
		" -NotDropDB -NotWriteLog -ExecuteDelete ..\..\U9.VOB.Product.Other\h_app\MetadataScript\ ..\..\U9.VOB.Product.Other\h_app\DBScript\

echo componet  buid end
pause

