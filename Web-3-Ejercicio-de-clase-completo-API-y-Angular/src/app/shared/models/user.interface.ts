export type Roles = 'admin' | 'user';


export interface User{
    username: String;
    password: String;
}

export interface UserResponse{
    message: String;
    token: String;
    role: String;
}