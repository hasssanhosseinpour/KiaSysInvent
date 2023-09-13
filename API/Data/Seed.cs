using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class Seed
    {
        public static async Task SeedUsers(DataContext context){
            //This means don't seed any data if there is any record.
            if(await context.Users.AnyAsync()) return;
            var userData = await File.ReadAllTextAsync("Data/UserSeedData.json");
            //This is just incase we made case mistaking inside our seeddata file.
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
            var users = JsonSerializer.Deserialize<List<AppUser>>(userData,options);
            //We are going to create password for each user ,foreach (var user in users):
            // and we'll do the same thing we did in register method plus using complex pa$$w0rd.
            foreach (var user in users)
            {
                using var hmac = new HMACSHA512();
                user.UserName = user.UserName.ToLower();
                user.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes("Pa$$w0rd"));
                user.PasswordSalt = hmac.Key;
                context.Users.Add(user);
            }
            await context.SaveChangesAsync();
        }
        public static async Task SeedItems(DataContext context){
            //This means don't seed any data if there is any record.
            if(await context.Items.AnyAsync()) return;
            var itemData = await File.ReadAllTextAsync("Data/ItemSeedData.json");
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
            var items = JsonSerializer.Deserialize<List<Item>>(itemData,options);
            foreach (var item in items)
            {
                context.Items.Add(item);
            }
            await context.SaveChangesAsync();
        }
        public static async Task SeedItemCategory(DataContext context){
            if(await context.ItemCategories.AnyAsync()) return;
            var data = await File.ReadAllTextAsync("Data/ItemCategoryData.json");
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
            var dataCollection = JsonSerializer.Deserialize<List<ItemCategory>>(data,options);
            foreach (var oneData in dataCollection)
            {
                context.ItemCategories.Add(oneData);
            }
            await context.SaveChangesAsync();
        }
         public static async Task SeedUnitOfMeasure(DataContext context){
            if(await context.UnitOfMeasures.AnyAsync()) return;
            var data = await File.ReadAllTextAsync("Data/UnitOfMeasureData.json");
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
            var dataCollection = JsonSerializer.Deserialize<List<UnitOfMeasure>>(data,options);
            foreach (var oneData in dataCollection)
            {
                context.UnitOfMeasures.Add(oneData);
            }
            await context.SaveChangesAsync();
        }
        public static async Task SeedSupplier(DataContext context){
            if(await context.Suppliers.AnyAsync()) return;
            var data = await File.ReadAllTextAsync("Data/SupplierData.json");
            var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
            var dataCollection = JsonSerializer.Deserialize<List<Supplier>>(data,options);
            foreach (var oneData in dataCollection)
            {
                context.Suppliers.Add(oneData);
            }
            await context.SaveChangesAsync();
        }
        // NO NEED TO SeedPhoto. It's been taken care of with the photo array inside the ItemSeedData.json
        // public static async Task SeedPhoto(DataContext context){
        //     if(await context.Photos.AnyAsync()) return;
        //     var data = await File.ReadAllTextAsync("Data/PhotoData.json");
        //     var options = new JsonSerializerOptions{PropertyNameCaseInsensitive= true};
        //     var dataCollection = JsonSerializer.Deserialize<List<Photo>>(data,options);
        //     foreach (var oneData in dataCollection)
        //     {
        //         context.Photos.Add(oneData);
        //     }
        //     await context.SaveChangesAsync();
        // }
    }
}