
# deutschland-api-sdk-csharp

This [SDK](https://github.com/apioo/deutschland-api-sdk-csharp) is managed by the [SDK Fabric](https://sdk-fabric.org/) project, a global infrastructure to
automatically generate SDKs for every API.

You can find more information about this SDK at [TypeHub](https://typehub.cloud/):
https://app.typehub.cloud/d/deutschland-api/sdk

## Usage

```csharp
using DeutschlandAPI.SDK.Client;

Client client = Client.Build("[access_token]")

// Returns user data of the current authenticated user.
Backend_User response = client.Authorization().getWhoami();

// Revoke the access token of the current authenticated user.
Common_Message response = client.Authorization().revoke();

// Returns available charging stations for a specific autobahn.
AutobahnChargingStationCollection response = client.Autobahn().Charging_station().getAll("autobahn_id");

// Returns available closures for a specific autobahn.
AutobahnClosureCollection response = client.Autobahn().Closure().getAll("autobahn_id");

// Returns all available autobahns.
AutobahnCollection response = client.Autobahn().getAll();

// Returns available parking lorries for a specific autobahn.
AutobahnParkingLorryCollection response = client.Autobahn().Parking_lorry().getAll("autobahn_id");

// Returns available warnings for a specific autobahn.
AutobahnWarningCollection response = client.Autobahn().Warning().getAll("autobahn_id");

// Returns expense for the provided year.
BudgetCollection response = client.Budget().Expense().getAll("year");

// Returns income for the provided year.
BudgetCollection response = client.Budget().Income().getAll("year");

// Returns all current members of the Bundesrat.
BundesratMemberCollection response = client.Bundesrat().Member().getAll();

// Returns a specific member of the Bundestag.
BundestagMember response = client.Bundestag().Member().get("member_id");

// Returns all current members of the Bundestag.
BundestagMemberCollection response = client.Bundestag().Member().getAll();

// Returns a specific city.
City response = client.City().get("city_id");

// Returns all available cities.
CityCollection response = client.City().getAll(1, "state", "district", "name", "zipCode");

// Returns a specific district.
District response = client.District().get("district_id");

// Returns all available districts.
DistrictCollection response = client.District().getAll(1, "state", "name");

// Returns all available hospitals.
HospitalCollection response = client.Hospital().getAll(1, "search");

// Returns all available jobs.
JobCollection response = client.Job().getAll(1, "search", "location", "employer");

// Returns meta information and links about the current installed Fusio version.
System_About response = client.Meta().getAbout();

// Returns all Tagesschau news.
NewsCollection response = client.News().getAll(1);

// Returns a specific state.
State response = client.State().get("state_id");

// Returns all available states.
StateCollection response = client.State().getAll(1, "name");

// Returns all available warnings from the modular warning system (MoWaS).
WarningCollection response = client.Warning().getAll();
```
