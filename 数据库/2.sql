--数据库默认设置，老师名字不重复。一个老师开的一门课只能在一个地方上。一个班级。
--学生信息表（学生id，年级，专业，用户名，密码，性别，年龄）
create table  student(
stuid  bigint primary key identity(1,1),--用户id
stuname varchar(30),--学生的真实姓名
stuxuehao varchar(30) not null unique,--学生的学号（默认为学生登录的用户名）
stupasswd   varchar(30) not null,--密码
stugrade varchar(30),--年级
stumajor varchar(30),--专业
stusex varchar(2) default '男',--性别
stuborn varchar(30),--出生日期
role	varchar(30) default '学生',
stuhometown varchar(30),--籍贯
)

--管理员信息表（管理员id，用户名，密码）
create table  manager(
manid  bigint primary key identity(1,1),--用户id
manname varchar(30) not null unique,--用户名
role	varchar(30) default '管理员',
manpasswd varchar(30) not null,--密码
)

--课程表（课程id，课程名，学期，学时,老师id）
create table  class(
claid  bigint primary key identity(1,1),--课程id
claname varchar(30),--课程名
term varchar(30),--学期
teacher varchar(30),--老师姓名
)

--上课时间的表
create table  sctime(
sctimeid bigint primary key identity(1,1),--上课时间id
claid bigint constraint csctime_id references class(claid),--课程的id
sctime varchar(30),--上课时间
location varchar(30),--上课地点
)

--选课表（选课id，课程id，学生id，成绩）
create table  sc(
scid  bigint primary key identity(1,1),--选课id
stuid bigint constraint ssc_id references student(stuid),--课程的id
claid bigint constraint scc_id references class(claid),--课程id
grades bigint --成绩
)
