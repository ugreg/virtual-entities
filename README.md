<p align="center"><img src="img/red.png"></p>

# Virtual Entities
Dynamics 365 Virtual Entity demo.

| <h1 align="center">Virtual Entity</h1><p align="center"><img src="img/p1.png" height="24"></p>
| :------------------------ |
| A virtual entity is a definition of an entity in the Common Data Service platform metadata without the associated physical tables for entity instances created in the Common Data Service database. Instead during runtime, when an entity instance is required, its state is dynamically retrieved from the associated external system. |


# Run

#### C Sharp
*in porgress*. . .
Download the project and click run. Even works on Mac!

#### Python
*in porgress*. . .
```python
set FLASK_APP=server.py
flask run
```

> INFO
>
> If you run into any issues running the code, debug the script using `python -m pdb .\server.py`

# Deploy to Azure

Create resource group
```
export rg="rg-virtual-entities"
az group create -n $rg -l 'West US'

```
Create resources
```bash
export server="server-dynamics-unit-test"
export db="db--dynamics-unit-test"
az sql server create --admin-password 'Password!' --admin-user admin --location 'West US' -n $server -g $rg

# A server-level firewall rule allows an external application, such as SQL Server Management Studio or the SQLCMD utility to connect to a SQL database through the SQL Database service firewall.
# To enable external connectivity, change the IP address to an appropriate address for your environment. To open all IP addresses, use 0.0.0.0 as the startip and 255.255.255.255 as andip.
export startip="0.0.0.0"
export endip="255.255.255.255"
az sql server firewall-rule create -g $rg --server $server -n AllowAnyIp --start-ip-address $startip --end-ip-address $endip

az sql db create -g $rg --server $server -n $db
```

Deploy REST API with OData.

# Get your own test Dataset

Used [Mockaroo](https://mockaroo.com/) to generate test data. You can use curl to test and get a response.
```bash
curl "https://api.mockaroo.com/api/0ad55780?count=100&key=d9e7f2e0" > "WebOrder-Virtual-Entity.csv"
```

# References

#### C Sharp
- [Creating an OData v4 API with ASP.NET Core 2.0](http://azurecoder.net/2018/02/19/creating-odata-api-asp-net-core-2-0/)
- Modified from [Getting started with OData in ASP.NET Core
](https://dotnetthoughts.net/getting-started-with-odata-in-aspnet-core/)
- Uses[Microsoft.AspNetCore.OData](https://www.nuget.org/packages/Microsoft.AspNetCore.OData/) and other NuGet libraries.

#### Python
- Modified from [Building a Basic RestFul API in Python
](https://www.codementor.io/sagaragarwal94/building-a-basic-restful-api-in-python-58k02xsiq) by [Sagar Chand Agarwal](https://github.com/sagaragarwal94)

- [SQLite](https://sqlite.org/download.html)
  - Binaries for the SQLite DLL, and for the SQLite Command Shell. Unzip the contents of the files in a folder then add the folder to your PATH variable
  - Helps to have the [db browser for sqlite](http://sqlitebrowser.org)
