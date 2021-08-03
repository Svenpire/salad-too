import { createAction, props } from '@ngrx/store';
import { User } from 'src/app/models/User';


// ------------ LOG IN / OUT ------------
export const loginAttempt = createAction(
  '[Login Modal] User Log In',
  props<{ email: string, password: string }>()
);

export const loginSuccess = createAction(
  '[Login Modal] User Log In Success',
  props<{ user: User }>()
);

export const loginFailure = createAction(
  '[Login Modal] User Log In Failure',
  props<{ error: any }>()
);

export const logout = createAction('[Nav] Log out');

// ------------ REGISTRATION ------------
export const registerUser = createAction(
  '[Login Modal] User Registration',
  props<{
    username: string,
    email: string
  }>()
);

export const registerUserSuccess = createAction(
  '[Login Modal] User Registration Success',
  props<{ user: User }>()
);

export const registerUserFailure = createAction(
  '[Login Modal] User Registration Failure',
  props<{ error: any }>()
);

// ------------ INITIAL: GUEST ------------
export const setGuestId = createAction(
  '[App Root] Set Guest ID',
  props<{ id: string }>()
)

// ------------ CONTACTS ------------
export const addContact = createAction(
  '[Owner Add] Add Contact',
  props<{
    name: string,
    email: string,
    img: string
  }>()
);

export const editUserName = createAction(
  '[Account] Edit User Name',
  props<{ name: string }>()
);


// ------------ ACCOUNT ------------
export const updateUserName = createAction(
  '[Account Name Edit Modal] Update User Name',
  props<{
    email: string,
    password: string,
    newUsername: string
  }>()
)

export const updateUserNameSuccess = createAction(
  '[Account Name Edit Modal] Update User Name Success',
  props<{ id: string, name: string }>()
)

export const updateUserNameFailure = createAction(
  '[Account Name Edit Modal] Update User Name Failure',
  props<{ error: any }>()
)
