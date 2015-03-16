# A minimal sample console application project with c# , entity framework and oracle that also runs in mono under linux.

For for this app the oracle database was 11g (docker image https://registry.hub.docker.com/u/wnameless/oracle-xe-11g/) and was tested with mono (docker image : https://registry.hub.docker.com/_/mono/).

To set up the database run an oracle instance and execute the SQLScript.sql after you created the database/schema 'OVI' (Don't know why my export tool didn't generate also database DDL)