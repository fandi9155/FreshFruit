﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FreeshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsOverload())
            {
                eventListener.onFailed("Ups, keranjang sudah penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.onSucceed("Yay, berhasil ditambahkan");
            }
        }

        public bool bucketIsOverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() != fruit.name)
                {
                    bucket.remove(itemPosition);
                    eventListener.onSucceed("Yay, behasil dihapus");
                }
            }
        }

        public List<Fruit> findAll()
        {
            return (List<Fruit>)this.bucket.findAll();
        }
    }
}
