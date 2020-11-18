using System;
using System.Collections.Generic;
using System.Text;

namespace FreeshFruit.Model{
    interface BucketEventListener
    {
        void onSucceed(string message);
        void onFailed(string message);
    }
}
