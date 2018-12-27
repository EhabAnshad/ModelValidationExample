# ModelValidationExample
##.NetCore model validation attributes 

### This is a wrong why to structure your API, this is only for showing all possible validations in single api call
---

Validations attributes in this example   
    CreditCard  
        Validates the property has a credit card format.  
    Compare  
        Validates two properties in a model match.  
    Phone  
        Validates the property has a telephone format.  
    Required  
        Makes a property required.  
    Url  
        Validates the property has a URL format.  
    EmailAddress  
        Validates the property has an email format.  
    Range  
        Validates the property value falls within the given range.  
    RegularExpression  
        Validates that the data matches the specified regular expression.  
    StringLength  
        Validates that a string property has at most the given maximum length.  
	DataType  
	  
---
  
Valid json for whole model  
{  
	"UserName": "Username",  
	"EmailAddress": "ehabanshad@yahoo.com",  
	"VerifyEmailAddress": "ehabanshad@yahoo.com",  
	"PhoneNumber": 123456789,  
	"accountList" :  
	[  
		{"CurrentBalance":55.5555,  
			"CreditCards":[  
				{  
					"CreditCardNumber":1234123123412344,  
					"ExpiryDate":"01/22",  
					"CCV":123  
				}  
				]  
		}  
	]  
}  