<img src="imgs/md/build-apps.png">

# Virtual Entities
---
Dynamics 365 Virtual Entity demo

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

# Deploy Azure

Create resources
```bash
az group create -n rg-dynamics-virtual-entities -l 'West US'

```

Deploy REST API with OData.

# Get your own Test Dataset

Used [Mockaroo](https://mockaroo.com/) to generate test data.
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
