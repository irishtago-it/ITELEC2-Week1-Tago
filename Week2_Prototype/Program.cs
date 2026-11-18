var first = new ProjectTask("Design login page", "Favorito", new DateTime(2026, 11, 25));
var second = new ProjectTask("Write test plan", "Mahilum", new DateTime(2026, 11, 27));

Console.WriteLine(first.Reassign("Dungo"));   // valid: expected True
first.MarkDone();
Console.WriteLine(first.Reassign("Carpio"));  // rule violation: expected False
Console.WriteLine(first.IsDone);              // expected True
Console.WriteLine(second.Reassign("Tago"));   // second object: expected True
