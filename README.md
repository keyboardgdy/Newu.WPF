# Newu.WPF

## 系统设计
利用WPF UI的骨架，添加登录界面和动态加载菜单。
基本的系统功能：用户管理，角色管理，功能管理。。。
代码生成，便捷的添加新页面的功能。包括后端代码和写入数据库

## 数据库设计
使用EF Core框架，采用Code Frist模式开发。

User 用户表
ID
姓名 Name
账户 Account
密码 Password
电话 Telephone
邮箱 Email
状态 Status
部门ID Organization_ID
备注 Remark
头像 Profile

Role 角色表
ID
角色名 Name
描述 Description
备注 Remark

功能表
ID
功能名 Name
页面命名空间 Code
图标 Icon
父级ID Rarent_ID
备注 Remark

组织机构表
Organization
ID
组织机构名 Name
负责人 Leader
电话 TelePhone
父级ID Rarent_ID
备注 Remark

关联表
用户角色表 User_Role
ID
用户ID User_ID
角色ID Role_ID

角色功能表 Role_Function
ID
角色ID Role_ID
功能ID Function_ID


创建人 Create_By
创建时间 Create_Time
修改人 Update_By
修改时间 Update_Time
