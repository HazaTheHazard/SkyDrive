using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SkyDrive.Models;

namespace SkyDrive.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SkyDriveContext context)
        {
            if (context.Note.Any())
            {
              return;  
            }

            var note = new Note[]
            {
                new Note
                {
                    UserID = "2",
                    Title = "The First Episode",
                    Body = "Vivamus maximus luctus hendrerit. Sed id erat consectetur, laoreet ex nec, pretium augue. Quisque congue iaculis nisl et imperdiet. Nunc dictum id orci ut malesuada. Proin mollis magna eget euismod aliquam. Vestibulum ac faucibus libero. Aenean scelerisque erat eu feugiat feugiat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Integer in urna libero. Curabitur nisl dui, pharetra et elementum rhoncus, congue non leo. Morbi vel leo at tellus dignissim venenatis et vel ipsum. Curabitur suscipit laoreet ex. Curabitur accumsan, nisi at sagittis ultricies, tellus enim sollicitudin massa, eu lobortis nisi mi condimentum quam. Vestibulum ornare neque a diam fringilla rhoncus. Quisque mollis sed ligula ut ullamcorper. Morbi pretium, nisl id placerat ullamcorper, arcu ligula dapibus augue, at laoreet ligula sapien eget sem. Nam interdum nulla facilisis, condimentum lacus non, rutrum nunc. Nunc dictum molestie dui nec dignissim. Phasellus in hendrerit massa. Morbi varius felis nisi, a commodo est euismod sed. Donec augue magna, finibus sit amet felis vel, varius cursus odio. Cras imperdiet sodales lectus, sed ornare ipsum egestas at. Proin tristique, arcu at ultricies rutrum, lectus dolor malesuada nisl, ut pretium arcu mauris a tellus. Curabitur egestas rutrum libero, ut tempor diam euismod quis. Nunc sit amet ipsum diam. Sed volutpat fermentum nisi quis semper. Suspendisse id felis vel erat egestas luctus. Morbi eu neque libero. Nullam eu tellus vitae velit ornare porta. Mauris rutrum ultricies aliquam. Donec consectetur tortor id euismod vulputate. Cras tortor tellus, feugiat quis egestas vel, scelerisque id ex. Donec ac pretium neque. Nullam iaculis nunc lacinia, ornare neque sed, dictum justo. Aenean sit amet est sit amet ex maximus finibus et at elit. Proin magna felis, facilisis sed vehicula vel, tristique ac ipsum. Nulla facilisi. Duis nec ultrices augue. Etiam dignissim quis erat vel tincidunt. Sed ut gravida nibh, eu eleifend neque.",
                },
                new Note
                {
                    UserID = "2",
                    Title = "Welcome Back",
                    Body = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. In ac ante massa. Integer eu turpis suscipit, lobortis massa gravida, hendrerit justo. Nullam tempus congue sagittis. Integer tempus, ante et placerat ultrices, dui nisi aliquet eros, ut mattis lacus elit id nisl. Sed vitae lectus eget tellus laoreet placerat ut vel turpis. In hac habitasse platea dictumst. In laoreet felis sed ante sollicitudin feugiat. Maecenas lobortis augue a commodo porta. Maecenas varius, eros efficitur volutpat luctus, dolor dui dignissim purus, pulvinar dapibus nunc odio non lectus. Donec maximus dapibus nisl sed efficitur. Nullam ornare ac urna eget suscipit. Integer condimentum interdum elit, non maximus felis sollicitudin sed.Maecenas augue metus, sodales eget dictum eu, efficitur at ante. Nullam gravida massa efficitur nulla congue, et maximus nisl dapibus. Donec et nibh nibh. Ut vehicula, metus ut ullamcorper facilisis, ligula risus fermentum nisl, a congue metus risus ut urna. Nunc vestibulum finibus bibendum. Aenean consectetur, felis nec tincidunt dignissim, erat metus suscipit purus, dignissim iaculis erat dui vitae nunc. Sed malesuada ullamcorper metus, id feugiat nunc euismod vestibulum. Suspendisse tincidunt dolor quis varius aliquet. Morbi mollis augue ac augue condimentum mattis. Suspendisse suscipit malesuada tortor at iaculis. Morbi tincidunt, turpis et pharetra aliquam, eros neque porta est, vel iaculis magna nibh in nunc. Suspendisse nec porttitor neque. Morbi bibendum consectetur laoreet.Vivamus maximus luctus hendrerit. Sed id erat consectetur, laoreet ex nec, pretium augue. Quisque congue iaculis nisl et imperdiet. Nunc dictum id orci ut malesuada. Proin mollis magna eget euismod aliquam. Vestibulum ac faucibus libero. Aenean scelerisque erat eu feugiat feugiat. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia Curae; Integer in urna libero. Curabitur nisl dui, pharetra et elementum rhoncus, congue non leo. Morbi vel leo at tellus dignissim venenatis et vel ipsum. Curabitur suscipit laoreet ex.",
                }
            };
            foreach (Note n in note)
            {
                context.Note.Add(n);
            }
            context.SaveChanges();

            var auth = new Auth[]
            {
                new Auth
                {
                    Email = "matthew.king4@sky.uk",
                    Password = "abcd1234",
                    FullName = "Matt King"
                },
                new Auth
                {
                    Email = "test@sky.uk",
                    Password = "abcd1234",
                    FullName = "test"
                }
            };

            foreach (Auth a in auth)
            {
                context.Auth.Add(a);
            }
            context.SaveChanges();

        }
    }
}