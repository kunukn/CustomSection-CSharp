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
	<companies>
		<company name="Google" code="googl"/>
		<company name="Apple" code="aapl"/>
	</companies>
</example03>
```

Example 4 - multiple lists of specified object
```
<example04>
	<item name="animals" area="land" host="asia">
		<types>
			<type name="elephant" value="100" />
			<type name="tiger" value="50" />
		</types>
	</item>
	<item name="people" area="water" host="africa">
		<types>
			<type name="surfer" value="200" />
			<type name="sailor" value="300" />
		</types>
	</item>
</example04>
```


