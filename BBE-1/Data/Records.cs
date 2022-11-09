namespace BBE_1.Data;

public class Record{
    public int id{get;}
    public int idUser{get;}
    public int idCategory{get;}
    public DateTime DateTimeOfRecord{get;}
    public int spent{get;}

    public Record(int id, int idUser, int idCategory, DateTime dateTimeOfRecord, int spent){
        this.id=id;
        this.idUser=idUser;
        this.idCategory = idCategory;
        this.DateTimeOfRecord = dateTimeOfRecord;
        this.spent = spent;
    }
}