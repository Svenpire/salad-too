import { state } from '@angular/animations';
import { Action, createReducer, on } from '@ngrx/store';
import { mutableOn } from 'ngrx-etc';
import { CartItem, Item } from 'src/app/models/Item';
import * as ItemActions from './item.actions';

export const itemFeatureKey = 'item';

export interface State extends CartItem {
  pickedIngredientTypeId: string
}

export const initialState: State = {
  id: null,
  name: null,
  itemGroup: null,
  ingredients: [],
  img: null,
  description: null,
  price: null,
  custom: null,
  owner: null,
  pickedIngredientTypeId: null
};


export const reducer = createReducer(
  initialState,

  on(ItemActions.setItemOwner, (state, action) => ({
    ...state, owner: {
      email: action.contact.email,
      img: action.contact.img,
      name: action.contact.name
    }
  })),
  on(ItemActions.setUserAsOwner, (state, action) => ({
    ...state,
    owner: {
      email: action.user.email,
      img: action.user.img,
      name: action.user.name
    }
  })),
  on(ItemActions.setCurrentOwnerAsItemOwner, (state, action) => ({
    ...state,
    owner: {
      email: action.owner.email,
      img: action.owner.img,
      name: action.owner.name
    }
  })),
  on(ItemActions.filterIngredientType, (state, action) => ({
    ...state, pickedIngredientTypeId: action.ingredientType
  })),

  // Item Owner Select
  on(ItemActions.setItemGroup, (state, action) => ({
    ...state, itemGroup: action.itemGroup
  })),
  on(ItemActions.clearItemGroup, (state) => ({
    ...state, itemGroup: null
  })),
  on(ItemActions.setItemId, (state, action) => ({
    ...state, id: action.id
  })),
  on(ItemActions.loadItem, (state, action) => ({
    ...state,
    id: action.item.id,
    name: action.item.name,
    itemGroup: action.item.itemGroup,
    ingredients: action.item.ingredients,
    img: action.item.img,
    description: action.item.description,
    price: action.item.price,
    custom: null,
    owner: null,
  })),
  mutableOn(ItemActions.toggleIngredient, (state, action) => {
    state.ingredients.push(action.ingredient)
  })
);

