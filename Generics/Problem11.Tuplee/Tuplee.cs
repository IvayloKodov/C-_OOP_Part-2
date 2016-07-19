﻿namespace Problem11.Tuplee
{
        public class Tuplee<TKey, TValue>
        {
            public Tuplee() : this(default(TKey), default(TValue))
            {
            }

            public Tuplee(TKey key, TValue value)
            {
                this.Key = key;
                this.Value = value;
            }
            public TKey Key { get;private set; }
            public TValue Value { get; private set; }
        
            public override string ToString()
            {
                return $"{this.Key} -> {this.Value}";
            }
        }
    }