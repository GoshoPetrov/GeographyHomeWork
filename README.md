# How to start the MS SQL server in a container locally

```
docker run \
  -e "ACCEPT_EULA=Y" \
  -e "MSSQL_SA_PASSWORD=Admin123!" \
  -e "MSSQL_PID=Evaluation" \
  -p 1433:1433  \
  --name sql20250 \
  --hostname sql20250 \
  -d mcr.microsoft.com/mssql/server:2025-latest
```
