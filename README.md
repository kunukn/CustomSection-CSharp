CustomSection CSharp
====================

How to: Create Custom Configuration Sections Using ConfigurationSection

http://msdn.microsoft.com/en-us/library/2tw134k3.aspx

Custom sections examples
------------------------

Example 1
```
<myConfiguration>
   <add name="name1" connectionName="conn1" fileDir="path1" baseUrl="baseUrl1" />
   <add name="name2" connectionName="conn2" fileDir="path2" baseUrl="baseUrl2" />
</myConfiguration>	
```

Example 2
```
<RegisterCompanies id="1">
   <Companies>
      <Company name="Tata Motors" code="Tata"/>
      <Company name="Honda Motors" code="Honda"/>
   </Companies>
</RegisterCompanies>
```

Example 3
```
<SiteSettings>
	<site name="develop" smtp="smtp.develop.com" host="localhost">
		<mappings>
			<membership name="name1" column="column1" />
			<membership name="name2" column="column2" />
		</mappings>
	</site>
	<site name="production" smtp="smtp.production.com" host="production.com">
		<mappings>
			<membership name="name3" column="column3" />
			<membership name="name4" column="column4" />
		</mappings>
	</site>
</SiteSettings>
```


