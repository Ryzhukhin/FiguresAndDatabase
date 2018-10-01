select
     p.[ProductName]
    ,c.[CategoryName]
  from ProductAndCategory as pc 
  left join Product  as p on p.id = pc.ProductId
  left join Category as c on c.id = pc.CategoryId