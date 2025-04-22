using SM.CardStudents;
using SM.Models;
using SM.Repository;

public interface INameRepository:IRepsitory<NameModel>
{
    List<NameModel> GetAllNames();
}
public class NameRepository : Repository<NameModel>, INameRepository
{
    public NameRepository() {
    
    
    }

    public override NameModel Serach(NameModel item)
    {
        return base.Serach(item);
    }
  

public List<NameModel> GetAllNames()
    {
        return Items.ToList();
    }
    

}