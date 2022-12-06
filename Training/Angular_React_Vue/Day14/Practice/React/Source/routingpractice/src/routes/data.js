let contacts=[
    {id:1, name:"Raj", number:"3698521470"},
    {id:2, name:"Yash", number:"9658741320"},
    {id:3, name:"Disha", number:"7582146930"}
]

export function getContacts()
{
    return contacts;
}

export function getSingleContact(id)
{
    return contacts.find((contact)=>contact.id === id);
}