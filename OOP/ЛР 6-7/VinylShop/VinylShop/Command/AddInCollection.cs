using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VinylShop.Entity;

namespace VinylShop.Command
{
    class AddInCollection : ICommand
    {
        CollectionStorage storage;
        VinylRecord vinylRecord;

        public AddInCollection(CollectionStorage storage, VinylRecord vinylRecord)
        {
            this.storage = storage;
            this.vinylRecord = vinylRecord.ShallowCopy();
        }

        public void Execute()
        {
            this.storage.GetCollection().Add(this.vinylRecord);
        }
    }
}
