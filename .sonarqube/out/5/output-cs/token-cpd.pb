±
IC:\Project\RetailShops\RetailShops.ServiceExtensions\ServiceExtensions.cs
	namespace		 	
RetailShops		
 
.		 
ServiceExtensions		 '
{

 
public 

static 
class 
ServiceExtensions )
{ 
public 
static 
IServiceCollection (
AddServices) 4
(4 5
this5 9
IServiceCollection: L
servicesM U
,U V
IConfigurationW e
configurationf s
)s t
{ 	
services 
. 
	AddScoped 
( 
typeof %
(% &
IUserRepository& 5
)5 6
,6 7
typeof8 >
(> ?
UserRepository? M
)M N
)N O
;O P
services 
. 
	AddScoped 
( 
typeof %
(% &
IInvoiceRepository& 8
)8 9
,9 :
typeof; A
(A B
InvoiceRepositoryB S
)S T
)T U
;U V
services 
. 
	AddScoped 
( 
typeof %
(% &$
IDiscountCountRepository& >
)> ?
,? @
typeofA G
(G H"
DiscountTypeRepositoryH ^
)^ _
)_ `
;` a
return 
services 
; 
} 	
public 
static 
void 
ConfigureSqlServer -
(- .
this. 2
IServiceCollection3 E
servicesF N
,N O
IConfigurationP ^
configuration_ l
)l m
=>n p
services	 
. 
AddDbContext 
<  
ApplicationContextDb 3
>3 4
(4 5
options5 <
=>= ?
options	 
. 
UseSqlServer 
( 
configuration +
.+ ,
GetConnectionString, ?
(? @
$str@ S
)S T
)T U
)U V
;V W
} 
} 