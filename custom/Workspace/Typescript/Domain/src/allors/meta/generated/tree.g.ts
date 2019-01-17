// Allors generated file.
// Do not edit this file, changes will be overwritten.
// tslint:disable:no-empty-interface
// tslint:disable:no-consecutive-blank-lines

import { Tree, MetaPopulation, ObjectType, TreeNode } from '../../framework';

export class TreeFactory {
    constructor(private metaPopulation: MetaPopulation) {
    }

    public Deletable(literal: TreeDeletable): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Deletable'], literal);
    }

    public Enumeration(literal: TreeEnumeration): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Enumeration'], literal);
    }

    public UniquelyIdentifiable(literal: TreeUniquelyIdentifiable): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['UniquelyIdentifiable'], literal);
    }

    public Version(literal: TreeVersion): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Version'], literal);
    }

    public Localised(literal: TreeLocalised): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Localised'], literal);
    }

    public ObjectState(literal: TreeObjectState): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['ObjectState'], literal);
    }

    public Task(literal: TreeTask): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Task'], literal);
    }

    public User(literal: TreeUser): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['User'], literal);
    }

    public WorkItem(literal: TreeWorkItem): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['WorkItem'], literal);
    }

    public Organisation(literal: TreeOrganisation): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Organisation'], literal);
    }

    public Person(literal: TreePerson): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Person'], literal);
    }

    public Settings(literal: TreeSettings): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Settings'], literal);
    }

    public Singleton(literal: TreeSingleton): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Singleton'], literal);
    }

    public Counter(literal: TreeCounter): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Counter'], literal);
    }

    public Media(literal: TreeMedia): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Media'], literal);
    }

    public MediaContent(literal: TreeMediaContent): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['MediaContent'], literal);
    }

    public Template(literal: TreeTemplate): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Template'], literal);
    }

    public TemplateType(literal: TreeTemplateType): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['TemplateType'], literal);
    }

    public PreparedExtent(literal: TreePreparedExtent): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['PreparedExtent'], literal);
    }

    public PreparedFetch(literal: TreePreparedFetch): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['PreparedFetch'], literal);
    }

    public Country(literal: TreeCountry): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Country'], literal);
    }

    public Currency(literal: TreeCurrency): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Currency'], literal);
    }

    public Language(literal: TreeLanguage): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Language'], literal);
    }

    public Locale(literal: TreeLocale): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Locale'], literal);
    }

    public LocalisedText(literal: TreeLocalisedText): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['LocalisedText'], literal);
    }

    public AccessControl(literal: TreeAccessControl): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['AccessControl'], literal);
    }

    public Login(literal: TreeLogin): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Login'], literal);
    }

    public Permission(literal: TreePermission): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Permission'], literal);
    }

    public Role(literal: TreeRole): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Role'], literal);
    }

    public SecurityToken(literal: TreeSecurityToken): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['SecurityToken'], literal);
    }

    public AutomatedAgent(literal: TreeAutomatedAgent): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['AutomatedAgent'], literal);
    }

    public Notification(literal: TreeNotification): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['Notification'], literal);
    }

    public NotificationList(literal: TreeNotificationList): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['NotificationList'], literal);
    }

    public TaskAssignment(literal: TreeTaskAssignment): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['TaskAssignment'], literal);
    }

    public TaskList(literal: TreeTaskList): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['TaskList'], literal);
    }

    public UserGroup(literal: TreeUserGroup): Tree {
        return new Tree(this.metaPopulation.objectTypeByName['UserGroup'], literal);
    }
}

export interface TreeDeletable {

   Organisation_Employees?: TreePerson;

   Person_Picture?: TreeMedia;

   Media_MediaContent?: TreeMediaContent;

   NotificationList_UnconfirmedNotifications?: TreeNotification;

   TaskAssignment_User?: TreeUser;
   TaskAssignment_Task?: TreeTask;

   TaskList_TaskAssignments?: TreeTaskAssignment;
   TaskList_OpenTaskAssignments?: TreeTaskAssignment;

   Task_WorkItem?: TreeWorkItem;
   Task_Participants?: TreePerson;
   Task_Performer?: TreePerson;

}


export interface TreeEnumeration {
   LocalisedNames?: Tree | TreeLocalisedText;

}


export interface TreeUniquelyIdentifiable {

   Person_Picture?: TreeMedia;

   Media_MediaContent?: TreeMediaContent;

   Enumeration_LocalisedNames?: TreeLocalisedText;

   Task_WorkItem?: TreeWorkItem;
   Task_Participants?: TreePerson;
   Task_Performer?: TreePerson;

}


export interface TreeVersion {

}


export interface TreeLocalised {
   Locale?: Tree | TreeLocale;

   Organisation_Employees?: TreePerson;


}


export interface TreeObjectState {

}


export interface TreeTask {
   WorkItem?: Tree | TreeWorkItem;
   Participants?: Tree | TreePerson;
   Performer?: Tree | TreePerson;

}


export interface TreeUser {
   TaskList?: Tree | TreeTaskList;
   NotificationList?: Tree | TreeNotificationList;

   Person_Picture?: TreeMedia;


}


export interface TreeWorkItem {

}


export interface TreeOrganisation {
   Employees?: Tree | TreePerson;
   Locale?: Tree | TreeLocale;

}


export interface TreePerson {
   Picture?: Tree | TreeMedia;
   TaskList?: Tree | TreeTaskList;
   NotificationList?: Tree | TreeNotificationList;

}


export interface TreeSettings {

}


export interface TreeSingleton {
   Settings?: Tree | TreeSettings;
   DefaultLocale?: Tree | TreeLocale;
   AdditionalLocales?: Tree | TreeLocale;
   Guest?: Tree | TreeUser;
   LogoImage?: Tree | TreeMedia;

}


export interface TreeCounter {

}


export interface TreeMedia {
   MediaContent?: Tree | TreeMediaContent;

}


export interface TreeMediaContent {

}


export interface TreeTemplate {

}


export interface TreeTemplateType {
   LocalisedNames?: Tree | TreeLocalisedText;

}


export interface TreePreparedExtent {

}


export interface TreePreparedFetch {

}


export interface TreeCountry {
   Currency?: Tree | TreeCurrency;
   LocalisedNames?: Tree | TreeLocalisedText;

}


export interface TreeCurrency {
   LocalisedNames?: Tree | TreeLocalisedText;

}


export interface TreeLanguage {
   LocalisedNames?: Tree | TreeLocalisedText;

}


export interface TreeLocale {
   Language?: Tree | TreeLanguage;
   Country?: Tree | TreeCountry;

}


export interface TreeLocalisedText {
   Locale?: Tree | TreeLocale;

}


export interface TreeAccessControl {

}


export interface TreeLogin {

}


export interface TreePermission {

}


export interface TreeRole {

}


export interface TreeSecurityToken {

}


export interface TreeAutomatedAgent {
   TaskList?: Tree | TreeTaskList;
   NotificationList?: Tree | TreeNotificationList;

}


export interface TreeNotification {

}


export interface TreeNotificationList {
   UnconfirmedNotifications?: Tree | TreeNotification;

}


export interface TreeTaskAssignment {
   User?: Tree | TreeUser;
   Task?: Tree | TreeTask;

}


export interface TreeTaskList {
   TaskAssignments?: Tree | TreeTaskAssignment;
   OpenTaskAssignments?: Tree | TreeTaskAssignment;

}


export interface TreeUserGroup {

}
