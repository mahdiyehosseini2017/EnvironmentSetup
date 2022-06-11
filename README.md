**Run SQL Server container images with Docker**

    • sudo docker pull mcr.microsoft.com/mssql/server:2019-latest
           (Pull the SQL Server 2019 Linux container image from Microsoft Container Registry)
           
    • sudo docker images
           (List of images)
      
    • sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong@Passw0rd>" -p 1433:1433 --name sql1 --hostname sql1 -d mcr.microsoft.com/mssql/server:2019-latest
           (Run the container image with Docker)
      
    • sudo docker ps -a
           (List of containers)

**connect to SQL Server Docker containers**

    • dotnet ef database update 
          (Create ContainerizeLearningDb database)

    • dotnet run
          (https://localhost:7253/api/v1/Personnels/1)

    • sudo docker exec -it sql1 /opt/mssql-tools/bin/sqlcmd -S localhost -U SA -P "<YourStrong@Passw0rd>"
          (Connect to SQL Server command-line tool)

    • select name from system.databases    go
          (List of databases)
          
**use data volumes to persist your data**
     
     • sudo docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<YourStrong@Passw0rd>" -p 1433:1433 --name sql1 --hostname sql1 -v /data:/var/opt/mssql/data -d mcr.microsoft.com/mssql/server:2019-latest
         (Mount a host directory as data volume)
       
     • sudo docker logs sql1
           (In case of error, check the log)
         
      • sudo chown -R 10001:0 <database file dir>
           (In case of "Access is denied" for non-root user error, set the non-root user as the owner of the files. "https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-docker-container-security?view=sql-server-ver16")
