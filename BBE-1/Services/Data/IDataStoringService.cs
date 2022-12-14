namespace BBE_1.Services.Data;

using BBE_1.Data;
public interface IUserService{
    void CreateUser(User user);
    
}
public interface ICategoryService{
    void CreateCategory(Category category);
    List<Category> GetCategories();
}
public interface IRecordService{
    void CreateRecord(Record record);
    List<Record>GetRecordsByUserId(int id);
    List<Record>GetRecordsByUserAndCategory(int userId, int categoryId);
}