export class ClientModel {
    clientId:number;
    firstName:string;
    lastName:string;
    DOB:Date;
    address:ClientAddress[];
}

export class ClientAddress{
    address:string;
}
