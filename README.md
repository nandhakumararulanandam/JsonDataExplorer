# JsonDataExplorer
A small utility built on top of Newtonsoft Json to query Json data using JsonPath

# Usage 
Build the source and execute the utility

- Load the *.json file and type in query to see the results

# Queries
Built on top of JsonPath 
 > JSONPath is a means of using XPath-like syntax to query JSON structures. Not to be confused with rest-assured's JsonPath implementation based on Groovy's Gpath. Use [tag:json-path-expression] for questions about JSON path expressions in general and for questions about JSON path expression DSLs.

# Example
Consider the following as the json content of the file being loaded in the tool
~~~javascript
{
  'Stores': [
    'Lambton Quay',
    'Willis Street'
  ],
  'Manufacturers': [
    {
      'Name': 'Acme Co',
      'Products': [
        {
          'Name': 'Anvil',
          'Price': 50
        }
      ]
    },
    {
      'Name': 'Contoso',
      'Products': [
        {
          'Name': 'Elbow Grease',
          'Price': 99.95
        },
        {
          'Name': 'Headlight Fluid',
          'Price': 4
        }
      ]
    }
  ]
}
~~~

### To Query `all names`

> **Query: **$..Name

### To Query `Get First Product Name`

> **Query: **$..Products[1].Name

### To Query `Get Product Whose Name is Anvil`

> **Query: **$..Products[?(@Name == 'Anvil')]

### To Query `Get Product Name whose price is greater than 4`

> **Query: **$..Products[?(@Price > 4)].Name
