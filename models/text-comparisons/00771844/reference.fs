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
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 24 * mm});
            skArc(sketch, "E1", {"start": v(34, 0) * mm, "mid": v(0, 34) * mm, "end": v(-34, 0) * mm});
            skLineSegment(sketch, "E2", {"start": v(-34, 0) * mm, "end": v(-34, -90) * mm});
            skLineSegment(sketch, "E3", {"start": v(-34, -90) * mm, "end": v(-14, -90) * mm});
            skLineSegment(sketch, "E4", {"start": v(-14, -90) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E5.MirrorCS", {"start": v(14, -90) * mm, "end": v(0, 0) * mm});
            skLineSegment(sketch, "E6.MirrorCS", {"start": v(34, -90) * mm, "end": v(14, -90) * mm});
            skLineSegment(sketch, "E7.MirrorCS", {"start": v(34, 0) * mm, "end": v(34, -90) * mm});
            skCircle(sketch, "E8", {"center": v(0, 0) * mm, "radius": 19 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"derivedFrom":[subQ1,subQ0]});Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,1.0]])],"derivedFrom":subQ1}),1.0]])]});}
            var Q1;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"derivedFrom":[subQ1,subQ0]});Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,-1.0]])],"derivedFrom":subQ1}),1.0]])]});}
            extrude(context, id + "F1", {"entities" : qUnion([Q0, Q1]), "depth" : 50 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"derivedFrom":[subQ1,subQ0]});Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,1.0]])],"derivedFrom":subQ1}),1.0]])]});}
            extrude(context, id + "F2", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 80 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "oppositeDirection" : true, "depth" : 60 * mm, "offsetDistance" : 25 * mm, "hasSecondDirection" : true, "secondDirectionOppositeDirection" : true, "secondDirectionDepth" : 10 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F3.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7.MirrorCS")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E9", {"center": v(-65, -35) * mm, "radius": 4.45 * mm});
            skCircle(sketch, "E10", {"center": v(-65, -35) * mm, "radius": 17.63 * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E9")}),-1.0]])]});
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F4.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F4.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F4.wireOp",EDGE,"E9")}),1.0]])]});
            extrude(context, id + "F6", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.SYMMETRIC, "depth" : 200 * mm, "offsetDistance" : 25 * mm});
        }
    });