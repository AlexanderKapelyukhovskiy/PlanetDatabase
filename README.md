# Planet Database
Simple Demo project (EntityFramework + Autofac + WebApi + Ember.js + NUnit + Moq)

To make demo work you need set up correct connection string in PlanetDatabase\PlanetDatabase.Web\Web.config
Currently it is:

```
<connectionStrings>
      <add name="Default"
         connectionString="Server=localhost\sqlexpress;Database=PlanetDatabase;Persist Security Info=True;integrated security=true;"
         providerName="System.Data.SqlClient" />
    </connectionStrings>
```

Demo project contains EntityFramework Automatic Migrations, so it will try to create database and tables during first database request. If you set connection string without necessary access rights it will fail to get necessary data for demo.