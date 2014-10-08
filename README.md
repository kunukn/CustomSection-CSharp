Custom Sections in config file
====================

How to: Create Custom Configuration Sections Using ConfigurationSection

http://msdn.microsoft.com/en-us/library/2tw134k3.aspx

Code samples of parsing data from custom sections
------------------------

Example 1 - name value pair
```
<example01>
	<add key="key1" value="value1" />
	<add key="key2" value="value2" />
</example01>
```

Example 2 - list of object
```
<example02>
	<add name="name1" value="value1" type="type1" />
	<add name="name2" value="value2" />
</example02>
```

Example 3 - list of specified object
```
<example03 id="1">
	<Companies>
		<Company name="Google" code="googl"/>
		<Company name="Apple" code="aapl"/>
	</Companies>
</example03>
```

Example 4 - multiple lists of specified object
```
<example04>
	<site name="develop" smtp="smtp.develop.com" host="develop.com">
		<mappings>
			<membership name="name1" value="value1" />
			<membership name="name2" value="value2" />
		</mappings>
	</site>
	<site name="production" smtp="smtp.production.com" host="production.com">
		<mappings>
			<membership name="name3" value="value3" />
			<membership name="name4" value="value4" />
		</mappings>
	</site>
</example04>
```


