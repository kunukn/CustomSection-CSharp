CustomSection CSharp
====================

How to: Create Custom Configuration Sections Using ConfigurationSection

http://msdn.microsoft.com/en-us/library/2tw134k3.aspx

Implementation example with list of elements

Custom sections examples
------------------------




```
<myConfiguration>
   <add name="name1" connectionName="conn1" fileDir="path1" baseUrl="baseUrl1" />
   <add name="name2" connectionName="conn2" fileDir="path2" baseUrl="baseUrl2" />
</myConfiguration>	
```


From http://stackoverflow.com/questions/1316058/how-to-create-custom-config-section-in-app-config

```
<RegisterCompanies id="1">
   <Companies>
      <Company name="Tata Motors" code="Tata"/>
      <Company name="Honda Motors" code="Honda"/>
   </Companies>
</RegisterCompanies>
```


