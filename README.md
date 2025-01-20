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

## 架构设计

- **用户界面层（UI Layer）**
    
- **业务逻辑层（Business Logic Layer）**
    
- **数据访问层（Data Access Layer)**

- **PresentationLayer**：包含视图、视图模型、模型、命令、资源和辅助类，用于实现用户界面和交互逻辑。
- **BusinessLogicLayer**：包含服务、业务对象、数据传输对象、验证器、辅助类和日志记录，用于处理业务逻辑。
- **DataAccessLayer**：包含数据库上下文、仓储、单元工作、数据传输对象、查询对象、日志记录、缓存和数据库迁移，用于与数据库交互。

## 项目结构目录

### 表示层

优化表示层（Presentation Layer）可以提高用户界面的响应速度、可维护性和用户体验。以下是一些优化建议：

1. **视图（View）**：
   - **分离视图和逻辑**：确保视图只负责展示，不包含业务逻辑。使用XAML定义UI元素和布局，保持视图的简洁。
   - **使用数据模板（Data Templates）**：定义数据模板来展示复杂的数据结构，提高代码的复用性和可读性。
   - **优化布局**：使用合适的布局控件（如Grid、StackPanel等）来优化界面布局，减少不必要的嵌套，提高渲染性能。

2. **视图模型（ViewModel）**：
   - **简化视图模型**：保持视图模型的简洁，只包含与视图相关的逻辑和数据。避免将业务逻辑放入视图模型中。
   - **使用命令（Commands）**：通过命令模式处理用户交互，避免在视图模型中直接处理事件。
   - **数据绑定（Data Binding）**：使用数据绑定将视图与视图模型连接起来，实现数据的双向绑定。确保数据绑定的路径正确，避免性能问题。

3. **样式和模板（Styles and Templates）**：
   - **统一样式**：使用资源字典（Resource Dictionary）定义全局样式，确保界面的一致性和美观性。
   - **模板化控件**：使用控件模板（Control Templates）自定义控件的外观和行为，提高界面的灵活性和可维护性。

4. **资源管理（Resource Management）**：
   - **优化资源加载**：使用延迟加载（Lazy Loading）和异步加载（Async Loading）技术，减少界面初始化时间。
   - **管理静态资源**：将图像、字符串等静态资源放入资源字典中，便于管理和维护。

5. **性能优化**：
   - **减少不必要的重绘**：避免频繁更新UI，减少不必要的重绘操作，提高界面响应速度。
   - **使用虚拟化技术**：对于大量数据的展示，使用虚拟化技术（如VirtualizingStackPanel）提高性能。

根据之前的架构设计，以下是一个优化后的表示层项目结构目录示例：

```
**Newu.WPF.UI**/
├── Views/
│   ├── MainWindow.xaml
│   ├── MainWindow.xaml.cs
│   ├── UserView.xaml
│   ├── UserView.xaml.cs
│   ├── OrderView.xaml
│   ├── OrderView.xaml.cs
│   └── ProductView.xaml
│       └── ProductView.xaml.cs
├── ViewModels/
│   ├── MainViewModel.cs
│   ├── UserViewModel.cs
│   ├── OrderViewModel.cs
│   └── ProductViewModel.cs
├── Models/
│   ├── UserModel.cs
│   ├── OrderModel.cs
│   └── ProductModel.cs
├── Commands/
│   ├── RelayCommand.cs
│   └── DelegateCommand.cs
├── Resources/
│   ├── Styles.xaml
│   ├── Templates.xaml
│   └── Images/
│       ├── logo.png
│       └── background.jpg
├── Helpers/
│   ├── NavigationHelper.cs
│   └── DialogHelper.cs
└── PresentationLayer.csproj
```

- **Views**：包含视图文件（XAML）和其对应的代码隐藏文件（.xaml.cs）。
- **ViewModels**：包含视图模型类，负责处理视图的逻辑和数据绑定。
- **Models**：包含模型类，表示业务数据和逻辑。
- **Commands**：包含命令类，用于处理用户交互。
- **Resources**：包含样式、模板和静态资源（如图像）。
- **Helpers**：包含辅助类，用于处理导航、对话框等常见操作。

### 业务逻辑层

优化业务逻辑层可以使系统更加模块化、可维护性更高，并且便于单元测试。以下是一些优化建议：

1. **服务层（Service Layer）**：
   - **抽象服务接口**：定义通用的业务逻辑接口，提供业务操作。这样可以实现业务逻辑的统一管理和复用。
   - **具体服务实现**：根据不同的业务需求实现具体的服务类，负责处理复杂的业务规则和流程。

2. **业务对象（Business Objects）**：
   - **领域模型（Domain Model）**：使用领域模型表示业务领域中的概念和数据。领域模型包含业务规则和验证逻辑。
   - **值对象（Value Objects）**：使用值对象表示不可变的业务数据，例如货币、日期等。

3. **数据传输对象（DTOs）**：
   - **简化数据结构**：使用DTOs在不同层之间传递数据，避免直接暴露领域模型。这样可以简化数据结构，提高系统的安全性和可维护性。

4. **服务层与数据访问层的分离**：
   - **依赖注入（Dependency Injection）**：使用依赖注入将数据访问层注入到服务层中，减少耦合度，提高可测试性。
   - **接口与实现分离**：将接口与实现分离，通过接口定义业务逻辑，通过实现类实现具体的业务操作。

5. **事务管理**：
   - **事务边界**：在服务层中定义事务边界，确保业务操作的一致性和完整性。可以使用单元工作模式管理事务。

6. **日志记录**：
   - **业务日志**：记录业务操作日志，便于调试和审计。可以使用日志框架记录业务操作的详细信息。

根据之前的架构设计，以下是一个优化后的业务逻辑层项目结构目录示例：

```
BusinessLogicLayer/
├── Services/
│   ├── IUserService.cs
│   ├── UserService.cs
│   ├── IOrderService.cs
│   ├── OrderService.cs
│   └── IProductService.cs
│       └── ProductService.cs
├── BusinessObjects/
│   ├── User.cs
│   ├── Order.cs
│   └── Product.cs
├── DTOs/
│   ├── UserDTO.cs
│   ├── OrderDTO.cs
│   └── ProductDTO.cs
├── Validators/
│   ├── UserValidator.cs
│   ├── OrderValidator.cs
│   └── ProductValidator.cs
├── Helpers/
│   ├── MappingHelper.cs
│   └── ValidationHelper.cs
├── Logs/
│   ├── LogHelper.cs
│   └── BusinessLog.cs
└── BusinessLogicLayer.csproj
```

- **Services**：包含抽象服务接口和具体服务实现类，负责处理业务逻辑。
- **BusinessObjects**：包含业务对象类，表示业务领域中的概念和数据。
- **DTOs**：包含数据传输对象，用于在不同层之间传递数据。
- **Validators**：包含验证器类，用于验证业务对象的数据。
- **Helpers**：包含辅助类，用于处理映射、验证等常见操作。
- **Logs**：包含日志记录相关的类，用于记录业务操作日志。

### 数据访问层

你说得对，使用EF Core框架构建数据访问层时，除了基本的CRUD操作，还可以包括以下内容来优化架构设计：

1. **数据库上下文（DbContext）**：
   - **配置数据库连接**：定义数据库上下文类，配置数据库连接字符串和初始化设置。
   - **管理数据库实体**：在数据库上下文类中定义数据库实体和表映射关系。

2. **仓储模式（Repository Pattern）**：
   - **抽象仓储接口**：定义通用的数据访问接口，提供CRUD操作。
   - **具体仓储实现**：根据不同的实体类实现具体的仓储类，负责与数据库的交互。

3. **单元工作模式（Unit of Work Pattern）**：
   - **事务管理**：通过单元工作模式管理数据库事务，确保数据操作的一致性和完整性。

4. **数据传输对象（DTOs）**：
   - **简化数据结构**：使用DTOs在不同层之间传递数据，避免直接暴露数据库实体。

5. **查询对象（Query Objects）**：
   - **封装查询逻辑**：将复杂的查询逻辑封装在查询对象中，提供灵活的查询接口。

6. **日志记录**：
   - **操作日志**：记录数据操作日志，便于调试和审计。可以使用SqlSugar的日志功能记录SQL语句和执行时间。

7. **缓存机制**：
   - **提高性能**：使用缓存机制存储常用数据，减少数据库访问次数，提高系统性能。可以结合SqlSugar的缓存功能实现数据缓存。

8. **数据库迁移（Database Migration）**：
   - **版本控制**：使用数据库迁移工具管理数据库版本，确保数据库结构的一致性和可追溯性。

根据之前的架构设计和使用EF Core框架，以下是一个优化后的数据访问层项目结构目录示例：

```
DataAccessLayer/
├── DbContext/
│   ├── ApplicationDbContext.cs
│   └── ApplicationDbContextConfig.cs
├── Repositories/
│   ├── IRepository.cs
│   ├── Repository.cs
│   ├── UserRepository.cs
│   ├── OrderRepository.cs
│   └── ProductRepository.cs
├── UnitOfWork/
│   ├── IUnitOfWork.cs
│   └── UnitOfWork.cs
├── DTOs/
│   ├── UserDTO.cs
│   ├── OrderDTO.cs
│   └── ProductDTO.cs
├── QueryObjects/
│   ├── IQueryObject.cs
│   ├── UserQuery.cs
│   ├── OrderQuery.cs
│   └── ProductQuery.cs
├── Logs/
│   ├── LogHelper.cs
│   └── DataAccessLog.cs
├── Cache/
│   ├── CacheHelper.cs
│   └── DataCache.cs
├── Migrations/
│   ├── MigrationHelper.cs
│   └── MigrationScripts/
│       ├── V1_InitialCreate.sql
│       └── V2_AddNewTable.sql
├── DataSeed/ 
│   └── DataSeed.cs
└── DataAccessLayer.csproj
```

- **DbContext**：包含数据库上下文类和配置类，用于配置数据库连接和管理数据库实体。
- **Repositories**：包含抽象仓储接口和具体仓储实现类，负责与数据库的交互。
- **UnitOfWork**：包含单元工作接口和实现类，用于管理事务。
- **DTOs**：包含数据传输对象，用于在不同层之间传递数据。
- **QueryObjects**：包含查询对象，用于封装复杂的查询逻辑。
- **Logs**：包含日志记录相关的类，用于记录数据操作日志。
- **Cache**：包含缓存相关的类，用于提高系统性能。
- **Migrations**：包含数据库迁移相关的类和脚本，用于管理数据库版本。

