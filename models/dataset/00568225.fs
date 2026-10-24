FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0", {"start": v(0, 0) * mm, "end": v(-4572, 0) * mm});
            skLineSegment(sketch, "E1", {"start": v(-4572, 0) * mm, "end": v(0, 3032.7217083009773) * mm});
            skLineSegment(sketch, "E2", {"start": v(0, 3032.7217083009764) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E3", {"start": v(0, 3032.7217083009773) * mm, "end": v(4572, 0) * mm});
            skLineSegment(sketch, "E4", {"start": v(0, 0) * mm, "end": v(4572, 0) * mm});
            skLineSegment(sketch, "E5", {"start": v(5181.6, 0) * mm, "end": v(4572, 0) * mm});
            skLineSegment(sketch, "E6", {"start": v(-4572, 0) * mm, "end": v(-4572, -5486.4) * mm});
            skLineSegment(sketch, "E7", {"start": v(-4572, -5486.4) * mm, "end": v(7620, -5486.4) * mm});
            skLineSegment(sketch, "E8", {"start": v(4572, 0) * mm, "end": v(4572, 2075.9928) * mm});
            skLineSegment(sketch, "E9", {"start": v(5181.6, 0) * mm, "end": v(5181.6, 2075.9928) * mm});
            skLineSegment(sketch, "E10", {"start": v(4572, 2075.9928) * mm, "end": v(5181.6, 2075.9928) * mm});
            skLineSegment(sketch, "E11", {"start": v(7620, -5486.4) * mm, "end": v(7620, 0) * mm});
            skLineSegment(sketch, "E12", {"start": v(5181.6, 0) * mm, "end": v(7620, 0) * mm});
            skLineSegment(sketch, "E13", {"start": v(0, -5486.4) * mm, "end": v(0, -3962.4) * mm});
            skLineSegment(sketch, "E14", {"start": v(0, -3962.4) * mm, "end": v(914.4, -3962.4) * mm});
            skLineSegment(sketch, "E15", {"start": v(914.4, -3962.4) * mm, "end": v(914.4, -5486.4) * mm});
            skPoint(sketch, "E16", {"position": v(0, -4724.4) * mm});
            skLineSegment(sketch, "E17.bottom", {"start": v(3048, -3048) * mm, "end": v(6096, -3048) * mm});
            skLineSegment(sketch, "E17.top", {"start": v(3048, -4267.2) * mm, "end": v(6096, -4267.2) * mm});
            skLineSegment(sketch, "E17.left", {"start": v(3048, -3048) * mm, "end": v(3048, -4267.2) * mm});
            skLineSegment(sketch, "E17.right", {"start": v(6096, -3048) * mm, "end": v(6096, -4267.2) * mm});
            skLineSegment(sketch, "E18.bottom", {"start": v(-3657.6, -2438.4) * mm, "end": v(-914.4, -2438.4) * mm});
            skLineSegment(sketch, "E18.top", {"start": v(-3657.6, -5181.6) * mm, "end": v(-914.4, -5181.6) * mm});
            skLineSegment(sketch, "E18.left", {"start": v(-3657.6, -2438.4) * mm, "end": v(-3657.6, -5181.6) * mm});
            skLineSegment(sketch, "E18.right", {"start": v(-914.4, -2438.4) * mm, "end": v(-914.4, -5181.6) * mm});
            skLineSegment(sketch, "E19", {"start": v(-2286, -2438.4) * mm, "end": v(-2286, -5181.6) * mm});
            skLineSegment(sketch, "E20", {"start": v(-3657.6, -3810) * mm, "end": v(-914.4, -3810) * mm});
            skLineSegment(sketch, "E21", {"start": v(4572, -3048) * mm, "end": v(4572, -4267.2) * mm});
            skLineSegment(sketch, "E22", {"start": v(3048, -3657.6) * mm, "end": v(6096, -3657.6) * mm});
            skText(sketch, "E23", { "text": "COLLIN JONES\n", "fontName": "OpenSans-Regular.ttf"});
            skLineSegment(sketch, "E24", {"start": v(-4572, -5486.4) * mm, "end": v(-4572, -6400.8) * mm});
            skLineSegment(sketch, "E25", {"start": v(7620, -5486.4) * mm, "end": v(7620, -6400.8) * mm});
            skLineSegment(sketch, "E26", {"start": v(7620, -6400.8) * mm, "end": v(-4572, -6400.8) * mm});
            const initialGuessF0  = {"E23": [-3.2195, 3.7475, 1, 0, 0.65316]};
            skSetInitialGuess(sketch, initialGuessF0);
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E5")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "endBound" : BoundingType.SYMMETRIC, "depth" : 914.4 * mm, "offsetDistance" : 30.48 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),1.0]])]});
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.SYMMETRIC, "depth" : 14630.4 * mm, "offsetDistance" : 30.48 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E2")}),1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0, Q1]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.SYMMETRIC, "depth" : 14020.8 * mm, "offsetDistance" : 30.48 * mm});
        }
        {
            var Q0;
            {var subQ4=sQuery(id+"F0.wireOp",EDGE,"E24");Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ4}),1.0]])]});}
            extrude(context, id + "F4", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "endBound" : BoundingType.SYMMETRIC, "depth" : 16764 * mm, "offsetDistance" : 30.48 * mm});
        }
    });