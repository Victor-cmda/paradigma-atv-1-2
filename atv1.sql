SELECT d.Nome AS Departamento,
    p.Nome AS Pessoa,
    p.Salario AS Salario
FROM Pessoa AS p
    JOIN Departamento AS d ON d.Id = p.DeptId
WHERE p.Salario = (
        SELECT MAX(p2.Salario)
        FROM Pessoa p2
        WHERE p2.DeptId = p.DeptId
    );