--------------------------------------------------------------------------------------
  _                                      ___                            
 | \  _  ._   _  ._   _|  _  ._   _       |  ._  o  _   _ _|_ o  _  ._  
 |_/ (/_ |_) (/_ | | (_| (/_ | | (_ \/   _|_ | | | (/_ (_  |_ | (_) | | 
         |                          /           _|                                              
--------------------------------------------------------------------------------------

Dependency Injection is a technique to receive certain behavior already instanced. 
In this way, we can separate responsibilities because the class that receives the
injection doesn't have to worry about to build additional logic to work.
In the example, the idea is to create a connection with a database. But before, 
the class "connection" receives as parameter one instance of the connector to use.