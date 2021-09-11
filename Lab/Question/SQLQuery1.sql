create database managequestion

use managequestion
create table question(
macauhoi varchar(10) primary key,
tencauhoi varchar(50) not null,
diem decimal not null,
dapan varchar(50) not null,

dapandung char not null,
)


select * from question