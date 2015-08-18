using DataSegmentExchangePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrell.Heart.Models
{
    /// <summary>
    /// Returns a new structure of oxygen to the consumer of the heart.
    /// </summary>
    public class Aorta : ModelBase
    {
        public Aorta()
        {
            Requirements.Add(Data.OperationalState);
            Requirements.Add(Data.ReplicantVersion);
        }

        public Oxygen Run(Dictionary<Data, object> segments) {

            OperationalState state = (OperationalState)segments[Data.OperationalState];
            Version version = (Version)segments[Data.ReplicantVersion];

            var oxygen = new Oxygen();

            switch (state)
            {
                case OperationalState.Idle:
                case OperationalState.Sleeping:
                    oxygen.Amount = 10;
                    break;

                case OperationalState.Normal:
                    oxygen.Amount = 50;
                    break;

                case OperationalState.Running:
                    oxygen.Amount = 75;
                    break;

                case OperationalState.Panic:
                    oxygen.Amount = 100;
                    break;
            }

            // The new models of replicants have an improved utilization of oxygen and need lower
            // levels returns for operation.
            if (version.Major > 2)
            {
                oxygen.Amount = oxygen.Amount * 0.8;
            }

            return oxygen;
        }
    }
}
