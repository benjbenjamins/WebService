Attached is the project as per the specification 

I have structured it as follows:

/Scripts - Contains all Database Generation Tables
/DomainRepository - Contains Database Context and Entities
/StoreDatabase - Contains Original Schema Design
/APIService - Contains the packaged API, helpers and models
/APIConsumer - Contains a console app with an example of how the API can be consumed
TODO: Deploy the API to test the APi Consumer further

Below is a list of the Endpoints Used in the Project and What they return;
Return all products
/Home/ReturnProduct?identifier=null

Return product byId 
/Home/ReturnProduct?identifier={Product.Id}

Return Product By Name
/Home/ReturnProduct?identifier={Product.Name}

Return Product By Category
Home/ReturnFeaturedProducts?SKU1={Product.SKU}&SKU1={Product.SKU}&SKU1{Product.SKU}

Return Categories
Home/ReturnCategory?identifier=null

Return Categories by Id
Home/ReturnCategory?identifier={Category.Id}

Return Category By Name
Home/ReturnCategory?identifier={Category.Name}



Issues I faced:
Creating Entity Relationships in EFCore version 5 for entities with many to one relationships.
I overcame this by pulling the data into the Category model directly and formatting into a product model list.
I also have not used Github so that was an interesting task and one I now feel comfortable with.

Things I left out:
I wanted to call the API methods using Ajax and update the Divs I commented out with the result 
I didnt have enough time to complete this due to the issue above.