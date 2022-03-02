USE sin;

insert into puesto values ("P1","Puesto 1","1");
insert into puesto values ("P2","Puesto 2","1");

insert into departamento values ("D1","Departamento 1","1");
insert into departamento values ("D2","Departamento 2","1");

insert into concepto values ("C1","Concepto 1","1","1");
insert into concepto values ("C2","Concepto 2","1","1");

-- empleado
insert into empleado values ("E1","Empleado 1","P1","D1","2500","1");
insert into empleado values ("E2","Empleado 2","P1","D2","2000","1");

insert into nominaE values ("NE1","2021/06/25","2021/12/25");
insert into nominaE values ("NE2","2021/03/25","2021/09/25");

insert into nominaD values ("ND1","E1","C1","500");
