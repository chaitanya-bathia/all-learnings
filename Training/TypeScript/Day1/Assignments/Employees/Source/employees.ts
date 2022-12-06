var arrEmployee = [
    {
      id: 1,
      firstName: 'Chaitanya',
      lastName: 'Bathia',
      Address: '502 Jamnagar Gujarat',
      Salary: 25000,
    },
  
    {
      id: 2,
      firstName: 'Rahul',
      lastName: 'Mehta',
      Address: '5 Mumbai Maharashtra',
      Salary: 25000,
    },
  
    {
      id: 3,
      firstName: 'Akash',
      lastName: 'Gupta',
      Address: '103 Rajkot Gujarat',
      Salary: 20000,
    },
  
    {
      id: 4,
      firstName: 'Divya',
      lastName: 'Mehra',
      Address: '202 Ahmedabad Gujarat',
      Salary: 20000,
    },
  
    {
      id: 5,
      firstName: 'Heli',
      lastName: 'Shah',
      Address: '301 Surat Gujarat',
      Salary: 25000,
    },
  ];
  
  var emp = [
    {
      id: 8,
      firstName: 'Meet',
      lastName: 'Mehra',
      Address: '801 Baroda Gujarat',
      Salary: 25000,
    },
  ];
  
  let searchindex = 2;
  
  for (const i of arrEmployee) {
    if (i.id == searchindex) {
      let addr = i.Address.split(' ');
      console.log(
        `ID:${i.id},  First name: ${i.firstName}, Last name: ${i.lastName},  Address: Flat no: ${addr[0]}, City: ${addr[1]}, State: ${addr[2]}, Salary: ${i.Salary}`
      );
    }
  }
  
  function pushData() {
    arrEmployee.push({
      id: 10,
      firstName: 'Jay',
      lastName: 'Joshi',
      Address: '1002 Baroda Gujarat',
      Salary: 30000,
    });
  }
  
  function popData() {
    var popped = arrEmployee.pop();
    console.log(`${popped.firstName} ${popped.lastName}`);
  }
  
  popData();
  
  function displayArray() {
    for (const x of arrEmployee) {
      let addressArr = x.Address.split(' ');
      console.log(`
            ${x.id},
            ${x.firstName} ${x.lastName},
            ${addressArr[0]},
            ${addressArr[1]},
            ${addressArr[2]},
            ${x.Salary + x.Salary * 0.12}`);
    }
  }
  