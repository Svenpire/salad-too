import { createFeatureSelector, createSelector } from '@ngrx/store';
import { Ingredients, IngredientTypes } from 'src/app/models/Ingredient';
import { Item, Items } from 'src/app/models/Item';
import { Desserts, Drinks, DrinkTypes, ItemGroups, Sides } from 'src/app/models/ItemGroup';
import { StaticData } from 'src/app/models/StaticData';
import * as fromStaticData from './static-data.reducer';

export const selectStaticDataState = createFeatureSelector<fromStaticData.State>(
  fromStaticData.staticDataFeatureKey
);

export const selectItemGroups = createSelector(
  selectStaticDataState,
  (state: StaticData): ItemGroups => state.itemGroups
)

export const selectItems = createSelector(
  selectStaticDataState,
  (state: StaticData): ItemGroups => state.items
)

export const selectDrinks = createSelector(
  selectStaticDataState,
  (state: StaticData): Drinks => {
    let drinks: Drinks
    drinks = state.items.filter(item =>
      item.itemGroup === 'drink'
    )
    return drinks
  }
)

export const selectSides = createSelector(
  selectStaticDataState,
  (state: StaticData): Sides => {
    let sides: Sides
    sides = state.items.filter(item =>
      item.itemGroup === 'side'
    )
    return sides
  }
)

export const selectDesserts = createSelector(
  selectStaticDataState,
  (state: StaticData): Desserts => {
    let desserts: Desserts
    desserts = state.items.filter(item =>
      item.itemGroup === 'side'
    )
    return desserts
  }
)

export const selectIngredients = createSelector(
  selectStaticDataState,
  (state: StaticData): Ingredients => state.ingredients
)

export const selectIngredientTypes = createSelector(
  selectStaticDataState,
  (state: StaticData): IngredientTypes => state.ingredientTypes
)

export const selectDrinkTypes = createSelector(
  selectStaticDataState,
  (state: StaticData): DrinkTypes => state.drinkTypes
)

