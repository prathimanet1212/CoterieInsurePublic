# Insurance Quote Rating Engine 
## Task
Generate a quote for a given input


## Example
Input payload of:
```
{
    revenue: 6000000,
    state: 'TX',
    business: 'Plumber'
}
```
Output payload of:
```
{
    premium: 11316
}
```

## Feature
- Current engine supports the following States
  - OH
  - FL
  - TX

- Current engine supports the following Business Types
  - Architect
  - Plumber
  - Programmer



## Future Enhancements
- [ ] Adding more business
- [ ] Adding more states
- [ ] Code Refactoring
  - [ ] Exception handling
  - [ ] Dependency Injection
  - [ ] Remove had coded values
  - [ ] Adding validations for Business and States
  - [ ] Create Interface for Calculator so that it will help us inject new calculator easily.
  - [ ] Adding cache service(for same input it will be same value no need to run engine again)
  - [ ] Project splitting to multiple project(API and Service)
  - [ ] Unit testing
  

 
