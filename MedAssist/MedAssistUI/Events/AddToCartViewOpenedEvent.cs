﻿using BusinessLogicV3.Models;
using EventAggregatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedAssistUI.Events
{
    class AddMedicationRequestViewOpenedEvent : AggregateEvent<MedicationRequestModel>
    {
    }
}
