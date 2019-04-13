--------------------------------------------------------------------------------------
  _                                              
 |_ _.  _ _|_  _  ._     |\/|  _ _|_ |_   _   _| 
 | (_| (_  |_ (_) | \/   |  | (/_ |_ | | (_) (_| 
                    /                            
--------------------------------------------------------------------------------------

With this common pattern, we can separate the process of creation in a concept called "factory".
A factory is responsible to choose the class to create the object. Often, this pattern is confused
with abstract factory pattern, the main difference is the last one has the concept "families" so that
means that it can work with many factories and concrete products.