namespace BBE_1.RAPI.Record;

public record CreateRecordRequest(
    int id,
    int idUser,
    int idCategory,
    int spent
);