import { Users } from "./User.interface";

export interface loginResponse{
    token: String;
    user: Users
}

export interface login{
    email: String;
    password: String;
}