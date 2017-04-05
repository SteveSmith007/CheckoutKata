# CheckoutKata
An example Supermarket Checkout

Notes:
The checkout uses 'Register' as the name for function which adds skus to the list of items purchased rather than 'Scan'.  This is because I believe it is a better name.  Checkout's don't scan, they register.  Scanners scan then pass the code they have scanned to the checkout to register the sku.  There could be are numerous methods by which skus are identified and registered.

Also, there are a few commits in the history where failing tests exist.  I wouldn't normally commit anything that had a failing tests but in this instance it serves to demonstrate the Test - Code - Refactor cycle followed.
