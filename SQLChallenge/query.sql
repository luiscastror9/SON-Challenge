select p.name,p.breed,p.age from Pets p
inner join Person_pets pp on p.id=pp.pet_id
inner join People pe on pe.id=pp.person_id
where pe.age>50 and p.dead=0
order by pe.age DESC

SELECT breed, COUNT(breed) AS cnt
FROM pets
GROUP BY breed
ORDER BY cnt DESC;