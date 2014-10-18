Custom Sections in config file
====================

How to: Create Custom Configuration Sections Using ConfigurationSection

http://msdn.microsoft.com/en-us/library/2tw134k3.aspx

Samples of custom sections
------------------------

The code has examples of how to extract data from the following custom sections

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
		<company name="Microsoft" code="msft"/>
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

Example 5 - multiple lists of specified object
```
<example05 activeBranch="[BranchToggle]">
	<toggles id="development-Q4">
		<toggle name="Sell"   />
		<toggle name="Stocks"  mode="disabled"  />
	</toggles>
	<toggles id="release-2016">
		<toggle name="Search"  />
		<toggle name="Sell"  mode="disabled"  />
		<toggle name="Stocks"  mode="disabled"  />
		<toggle name="Buy" mode="enabled" fromDate="31-01-2015" />
	</toggles>
</example05>
```


http://kunuk.wordpress.com/2014/10/12/custom-configuration-section-samples-csharp/

