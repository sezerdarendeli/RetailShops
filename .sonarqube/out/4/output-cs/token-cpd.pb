‘
SC:\Project\RetailShops\RetailShops.Repositories\Contracts\DiscountTypeRepository.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #
	Contracts# ,
{ 
public 

class "
DiscountTypeRepository '
:( )
RepositoryBase* 8
<8 9
DiscountTypeEntity9 K
>K L
,L M$
IDiscountCountRepositoryN f
{ 
private 
readonly  
ApplicationContextDb -

_dbContext. 8
;8 9
public "
DiscountTypeRepository %
(% & 
ApplicationContextDb& :
	dbContext; D
)D E
: 	
base
 
( 
	dbContext 
) 
{ 	

_dbContext 
= 
	dbContext "
;" #
} 	
public 
string !
GetDiscountPercentage +
(+ ,
DiscountTypeEntity, >
discount? G
)G H
{ 	
throw   
new   #
NotImplementedException   -
(  - .
)  . /
;  / 0
}!! 	
public## 
Task## 
<## 
DiscountTypeEntity## &
>##& '#
GetDiscountTypeByTypeId##( ?
(##? @
int##@ C
typeId##D J
)##J K
{$$ 	
return%% 

_dbContext%% 
.%% 
Set%% !
<%%! "
DiscountTypeEntity%%" 4
>%%4 5
(%%5 6
)%%6 7
.&& 
AsNoTracking&& 
(&&  
)&&  !
.'' 
FirstOrDefaultAsync'' &
(''& '
e''' (
=>'') +
e'', -
.''- .
Id''. 0
==''1 3
typeId''4 :
)'': ;
;''; <
}(( 	
}** 
}++ Ý
NC:\Project\RetailShops\RetailShops.Repositories\Contracts\InvoiceRepository.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #
	Contracts# ,
{ 
public 

class 
InvoiceRepository "
:# $
RepositoryBase% 3
<3 4
InvoicesEntity4 B
>B C
,C D
IInvoiceRepositoryE W
{ 
private 
readonly  
ApplicationContextDb -

_dbContext. 8
;8 9
public 
InvoiceRepository  
(  ! 
ApplicationContextDb! 5
	dbContext6 ?
)? @
: 	
base
 
( 
	dbContext 
) 
{ 	

_dbContext 
= 
	dbContext "
;" #
} 	
public 
async 
Task 
< 
InvoicesEntity (
>( )
GetInvoiceTotal* 9
(9 :
string: @
serialNumberA M
)M N
{ 	
return 
await 
FindByCondition (
(( )
i) *
=>+ -
i. /
./ 0
InvoiceSerialNumber0 C
.C D
EqualsD J
(J K
serialNumberK W
)W X
)X Y
.Y Z 
SingleOrDefaultAsyncZ n
(n o
)o p
;p q
} 	
public 

IQueryable 
< 
InvoicesEntity (
>( )
FindByCondition* 9
(9 :

Expression: D
<D E
FuncE I
<I J
InvoicesEntityJ X
,X Y
boolZ ^
>^ _
>_ `

expressiona k
)k l
{ 	
return 

_dbContext 
. 
Set !
<! "
InvoicesEntity" 0
>0 1
(1 2
)2 3
.3 4
Where4 9
(9 :

expression: D
)D E
.E F
AsNoTrackingF R
(R S
)S T
;T U
}   	
}!! 
}"" í
KC:\Project\RetailShops\RetailShops.Repositories\Contracts\RepositoryBase.cs
	namespace

 	
RetailShops


 
.

 
Repositories

 "
.

" #
	Contracts

# ,
{ 
public 

class 
RepositoryBase 
<  
TEntity  '
>' (
:) *
IRepositoryBase+ :
<: ;
TEntity; B
>B C
where 
TEntity 
: 
class 
, 
IEntity &
{ 
private 
readonly 
	DbContext "

_dbContext# -
;- .
public 
RepositoryBase 
( 
	DbContext '
	dbContext( 1
)1 2
{ 	

_dbContext 
= 
	dbContext "
;" #
} 	
public 
List 
< 
TEntity 
> 
GetAll #
(# $
)$ %
{ 	
return 

_dbContext 
. 
Set !
<! "
TEntity" )
>) *
(* +
)+ ,
., -
AsNoTracking- 9
(9 :
): ;
.; <
ToList< B
(B C
)C D
;D E
} 	
public 
async 
Task 
< 
TEntity !
>! "
GetById# *
(* +
int+ .
id/ 1
)1 2
{ 	
return 
await 

_dbContext #
.# $
Set$ '
<' (
TEntity( /
>/ 0
(0 1
)1 2
. 
AsNoTracking 
( 
) 
. 
FirstOrDefaultAsync $
($ %
e% &
=>' )
e* +
.+ ,
Id, .
==/ 1
id2 4
)4 5
;5 6
}   	
public"" 
async"" 
Task"" 
Create""  
(""  !
TEntity""! (
entity"") /
)""/ 0
{## 	
await$$ 

_dbContext$$ 
.$$ 
Set$$  
<$$  !
TEntity$$! (
>$$( )
($$) *
)$$* +
.$$+ ,
AddAsync$$, 4
($$4 5
entity$$5 ;
)$$; <
;$$< =
await%% 

_dbContext%% 
.%% 
SaveChangesAsync%% -
(%%- .
)%%. /
;%%/ 0
}&& 	
public(( 
async(( 
Task(( 
Update((  
(((  !
int((! $
id((% '
,((' (
TEntity(() 0
entity((1 7
)((7 8
{)) 	

_dbContext** 
.** 
Set** 
<** 
TEntity** "
>**" #
(**# $
)**$ %
.**% &
Update**& ,
(**, -
entity**- 3
)**3 4
;**4 5
await++ 

_dbContext++ 
.++ 
SaveChangesAsync++ -
(++- .
)++. /
;++/ 0
},, 	
public.. 
async.. 
Task.. 
Delete..  
(..  !
int..! $
id..% '
)..' (
{// 	
var00 
entity00 
=00 
await00 

_dbContext00 )
.00) *
Set00* -
<00- .
TEntity00. 5
>005 6
(006 7
)007 8
.008 9
	FindAsync009 B
(00B C
id00C E
)00E F
;00F G

_dbContext11 
.11 
Set11 
<11 
TEntity11 "
>11" #
(11# $
)11$ %
.11% &
Remove11& ,
(11, -
entity11- 3
)113 4
;114 5
await22 

_dbContext22 
.22 
SaveChangesAsync22 -
(22- .
)22. /
;22/ 0
}33 	
}44 
}55 ç

KC:\Project\RetailShops\RetailShops.Repositories\Contracts\UserRepository.cs
	namespace

 	
RetailShops


 
.

 
Repositories

 "
.

" #
	Contracts

# ,
{ 
public 

class 
UserRepository 
:  !
RepositoryBase" 0
<0 1

UserEntity1 ;
>; <
,< =
IUserRepository> M
{ 
public 
UserRepository 
(  
ApplicationContextDb 2
	dbContext3 <
)< =
: 
base 
( 
	dbContext 
) 
{ 	
} 	
public 
Task 
< 

UserEntity 
> 
GetUserById  +
(+ ,
int, /
userId0 6
)6 7
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
public 
Task 
< 

UserEntity 
> 
GetUserByName  -
(- .
int. 1
userId2 8
)8 9
{ 	
throw 
new #
NotImplementedException -
(- .
). /
;/ 0
} 	
} 
} ª
VC:\Project\RetailShops\RetailShops.Repositories\Interfaces\IDiscountCountRepository.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #

Interfaces# -
{		 
public

 

	interface

 $
IDiscountCountRepository

 -
:

. /
IRepositoryBase

0 ?
<

? @
DiscountTypeEntity

@ R
>

R S
{ 
string !
GetDiscountPercentage $
($ %
DiscountTypeEntity% 7
discount8 @
)@ A
;A B
Task 
< 
DiscountTypeEntity 
>  #
GetDiscountTypeByTypeId! 8
(8 9
int9 <
typeId= C
)C D
;D E
} 
} ý
PC:\Project\RetailShops\RetailShops.Repositories\Interfaces\IInvoiceRepository.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #

Interfaces# -
{ 
public		 

	interface		 
IInvoiceRepository		 '
:		( )
IRepositoryBase		* 9
<		9 :
InvoicesEntity		: H
>		H I
{

 
Task 
< 
InvoicesEntity 
> 
GetInvoiceTotal ,
(, -
string- 3
serialNumber4 @
)@ A
;A B
} 
} ”	
MC:\Project\RetailShops\RetailShops.Repositories\Interfaces\IRepositoryBase.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #

Interfaces# -
{ 
public		 

	interface		 
IRepositoryBase		 $
<		$ %
TEntity		% ,
>		, -
where

	 
TEntity

 
:

 
class

 
{ 
List 
< 
TEntity 
> 
GetAll 
( 
) 
; 
Task 
< 
TEntity 
> 
GetById 
( 
int !
id" $
)$ %
;% &
Task 
Create 
( 
TEntity 
entity "
)" #
;# $
Task 
Update 
( 
int 
id 
, 
TEntity #
entity$ *
)* +
;+ ,
Task 
Delete 
( 
int 
id 
) 
; 
} 
} —
MC:\Project\RetailShops\RetailShops.Repositories\Interfaces\IUserRepository.cs
	namespace 	
RetailShops
 
. 
Repositories "
." #

Interfaces# -
{ 
public		 

	interface		 
IUserRepository		 $
:		% &
IRepositoryBase		' 6
<		6 7

UserEntity		7 A
>		A B
{

 
Task 
< 

UserEntity 
> 
GetUserById $
($ %
int% (
userId) /
)/ 0
;0 1
Task 
< 

UserEntity 
> 
GetUserByName &
(& '
int' *
userId+ 1
)1 2
;2 3
} 
} 