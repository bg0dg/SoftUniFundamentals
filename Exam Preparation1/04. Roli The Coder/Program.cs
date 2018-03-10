using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Roli_The_Coder
{
    class Program
    {
        static void Main(string[] args)
        {
            var eventIdToNames = new Dictionary<int, string>(); //ID to names
            var eventParticipants = new Dictionary<int, List<string>>(); // ID to list of participants

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var commandParts = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var eventId = 0;
                if (!int.TryParse(commandParts[0], out  eventId))
                {
                    continue;
                }

                var eventName = commandParts[1];
                if (!eventName.StartsWith("#"))
                {
                    continue;
                }

                eventName = eventName.Trim('#');

                var participants = new List<string>();

                //From here ...

                var invalidPaticipants = false;

                for (int i = 2; i < commandParts.Length; i++)
                {
                    var participant = commandParts[i];

                    if (!participant.StartsWith("@"))
                    {
                        invalidPaticipants = true;
                        break;
                    }

                    participants.Add(participant);
                }

                if (invalidPaticipants)
                {
                    continue;
                }

                //.. to here can be done by Regex:

                //var participants = new List<string>();
                //var regex = new Regex(@"@[a-zA-Z\-\'\d]+");
                //var matches = regex.Matches(input);
                //foreach (Match participant in matches)
                //{
                //    participants.Add(participant.ToString());
                //}

                var dublicatedEventToId = eventIdToNames.ContainsKey(eventId); //In the list "eventIdToNames" exist ID with "eventId"

                if (dublicatedEventToId)
                {
                    var existingEventName = eventIdToNames[eventId];

                    if (existingEventName == eventName)
                    {
                        eventParticipants[eventId].AddRange(participants);
                    }
                }
                else
                {
                    eventIdToNames[eventId] = eventName;
                    eventParticipants[eventId] = new List<string>(participants); //Adding the patisipants in the list
                }

            }

            var events = eventParticipants
                .Select(kvp => new //new object
                {
                    Id = kvp.Key,
                    Name = eventIdToNames[kvp.Key],
                    Participants = kvp.Value
                    .Distinct()
                    .OrderBy(p => p)
                    .ToList()
                })
                .OrderByDescending(kvp => kvp.Participants.Count)
                .ThenBy(ev => ev.Name)
                .ToList();
                

            foreach (var ev in events)
            {
                var evId = ev.Id;
                var evName = ev.Name;
                var participants = ev.Participants;

                Console.WriteLine($"{evName} - {participants.Count()}");

                foreach (var participant in participants)
                {
                    Console.WriteLine(participant);
                }
            }

        }
    }
}
